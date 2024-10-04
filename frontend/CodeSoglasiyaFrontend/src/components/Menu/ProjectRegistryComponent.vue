<template>
  <div class="checkboxes">
    <input type="checkbox" v-model="thisYearProjects" @click="thisYearProjects = !thisYearProjects; updateFilters()" checked>Портфель проектов 2024
    <input type="checkbox" v-model="archiveProjects" @click="archiveProjects = !archiveProjects; updateFilters()">Архивные проекты
  </div>

  <div class="buttons">
    <div class="functional-buttons">
      <button @click="exportFile()">
        Экспорт
      </button>
      <button>
        Группировать
      </button>
      Поиск:
      <input @keydown.enter="fetchItems('search', searchQuery)" v-model="searchQuery">
    </div>

    <div class="filter-buttons">
      <button class="home-button" @click="goHome">
        <img src="@/assets/svg/home.svg" width="16px" height="16px">
      </button>
      <button :class="{'picked-button': tableHead === GeneralInfo}" @click="fetchItems(GeneralInfo, 'GeneralInfo')">Общая информация</button>
      <button :class="{'picked-button': tableHead === Condition}" @click="fetchItems(Condition, 'Condition')">Состояние</button>
      <button :class="{'picked-button': tableHead === Team}" @click="fetchItems(Team, 'Team')">Команда проекта</button>
      <button :class="{'picked-button': tableHead === Timelines}" @click="fetchItems(Timelines, 'Timelines')">Сроки</button>
      <button :class="{'picked-button': tableHead === Cost}" @click="fetchItems(Cost, 'Cost')">Стоимость</button>
      <button :class="{'picked-button': tableHead === Documents}" @click="fetchItems(Documents, 'Documents')">Документация</button>
      <button :class="{'picked-button': tableHead === Goals}" @click="fetchItems(Goals, 'Goals')">Цели</button>
      <button :class="{'picked-button': tableHead === Monitoring}" @click="fetchItems(Monitoring, 'Monitoring')">Мониторинг</button>
    </div>
  </div>

  <div class="projects-table">
    <TableComponent
      :data="tableData"
      :columns="tableHead"
      :filter-key="searchQuery">
    </TableComponent>
  </div>
</template>

<script>
import TableComponent from "./Table/TableComponent.vue"

// Headers for table
import HomeJSON from "@/data/home-head.json"
import GeneralInfoJSON from "@/data/general-info-head.json"
import ConditionJSON from "@/data/condition-head.json"
import TeamJSON from "@/data/team-head.json"
import TimelinesJSON from "@/data/timelines-head.json"
import CostJSON from "@/data/cost-head.json"
import DocumentsJSON from "@/data/documents-head.json"
import GoalsJSON from "@/data/goals-head.json"
import MonitoringJSON from "@/data/monitoring-head.json"

import api from "@/api"

export default {
  components: {
    TableComponent
  },
  data() {
    return {
      tableData: [],
      tableHead: HomeJSON,
      Home: HomeJSON,
      GeneralInfo: GeneralInfoJSON,
      Condition: ConditionJSON,
      Team: TeamJSON,
      Timelines: TimelinesJSON,
      Cost: CostJSON,
      Documents: DocumentsJSON,
      Goals: GoalsJSON,
      Monitoring: MonitoringJSON,
      searchQuery: "",
      thisYearProjects: true,
      archiveProjects: false,
      startURL: "/ProjectRegistry/Views"
    }
  },
  methods: {
    goHome() {
      this.thisYearProjects = true
      this.archiveProjects = false  
      this.tableHead = this.Home
      this.fetchItems('home', '/Home')
    },
    // Excel file export
    async exportFile() {
      try {
        let filename = (Math.floor(Date.now() / 1000)) + '.xlsx';
        const response = await api.apiClientExportFile('/swagger/index.html')
        // or use application/vnd.ms-excel for .xls
        let url = window.URL.createObjectURL(new Blob([response.data], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' }));
        let link = document.createElement('a');
        link.href = url;
        link.setAttribute('download', filename);
        document.body.appendChild(link);
        link.click();
        
        link.parentNode.removeChild(link);
        window.URL.revokeObjectURL(url);
      } catch (error) {
        console.log('Error downloading the file', error);
      }
    },
    // Fetches table data
    async fetchItems(headers, endURL) {
      try {
        let URL = ""
        if (headers === "search") {
          URL = this.startURL + "?searchQuery=" + endURL 
          // on testing check the URL
        } else if (headers === "home") {
          URL = this.startURL + endURL
          console.log(URL)
        } else {
          this.tableHead = headers
          URL = this.startURL + "/Projects" + endURL
        }
        const response = await api.getItemsJSON(URL)
        this.tableData = response.data
      } catch (error) {
        console.error('Error fetching items:', error)
      }
    },
    // Updates checkbox filters
    async updateFilters () {
      try {
        const URL = this.startURL + "?thisYearProjects=" + this.thisYearProjects + "&archiveProjects=" + this.archiveProjects
        const response = await api.getItemsJSON(URL)
        this.tableData = response.data
      } catch (error) {
        console.error('Error updating filters:', error)
      }
    }
  }
}
</script>

<style scoped>
.checkboxes input {
  cursor: pointer;
}
.buttons {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  padding: 10px 0 0 0;
}
.functional-buttons {
  display: flex;
  flex-direction: row;
  align-items: end;
}
.functional-buttons button {
  margin-right: 5px;
}
.filter-buttons {
  display: flex;
  flex-direction: row;
}
.filter-buttons button {
  margin-left: 5px;
}
.home-button {
  background-color: #9c1c1c;
}
.projects-table {
  padding: 5px 0;
}
</style>