<template>
  <div class="checkboxes">
    <input type="checkbox" v-model="thisYearProjects" @click="thisYearProjects = !thisYearProjects; updateFilters()" checked>Портфель проектов 2024
    <input type="checkbox" v-model="archiveProjects" @click="archiveProjects = !archiveProjects; updateFilters()">Архивные проекты
    <input type="checkbox" v-model="portfolioProject" @click="portfolioProject = !portfolioProject; updateFilters()">Проект портфеля 2024
  </div>

  <div class="buttons">
    <div class="functional-buttons">
      <button @click="exportFile()">
        Экспорт
      </button>
      <div class="custom-select">
        <button class="select-selected" @click="optionsHide = !optionsHide">
          Группировать
        </button>
        <div class="select-items" :class="{'select-hide': optionsHide}">
          <div v-for="option in options" :key="option" @click="filteredData = dataGrouping(option)">
            {{ option }}
          </div>
        </div>
      </div>
      Поиск:
      <input @keydown.enter="fetchSearchResponse()" v-model="searchTerm">
    </div>

    <div class="filter-buttons">
      <button class="home-button" @click="fetchItemsHome(); tableHeadName = Home">
        <img src="@/assets/svg/home.svg" width="16px" height="16px">
      </button>
      <button 
        :class="{'picked-button': tableHead === GeneralInfo}" 
        @click="fetchItems(GeneralInfo, '/GeneralInfo'); tableHeadName = GeneralInfo"
      >
        Общая информация
      </button>
      <button 
        :class="{'picked-button': tableHead === Condition}"
        @click="fetchItems(Condition, '/Condition'); tableHeadName = Condition"
      >
        Состояние
      </button>
      <button 
        :class="{'picked-button': tableHead === Team}" 
        @click="fetchItems(Team, '/Team'); tableHeadName = Team"
      >
        Команда проекта
      </button>
      <button 
        :class="{'picked-button': tableHead === Timelines}" 
        @click="fetchItems(Timelines, '/Timelines'); tableHeadName = Timelines"
      >
        Сроки
      </button>
      <button 
        :class="{'picked-button': tableHead === Cost}" 
        @click="fetchItems(Cost, '/Cost'); tableHeadName = Cost"
      >
        Стоимость
      </button>
      <button 
        :class="{'picked-button': tableHead === Documents}" 
        @click="fetchItems(Documents, '/Documents'); tableHeadName = Documents"
      >
        Документация
      </button>
      <button 
        :class="{'picked-button': tableHead === Goals}" 
        @click="fetchItems(Goals, '/Goals'); tableHeadName = Goals"
      >
        Цели
      </button>
      <button 
        :class="{'picked-button': tableHead === Monitoring}" 
        @click="fetchItems(Monitoring, '/Monitoring'); tableHeadName = Monitoring"
      >
        Мониторинг
      </button>
    </div>
  </div>

  <div class="projects-table">
    <TableComponent
      :data="filteredData"
      :columns="tableHead"
      :filter-key="searchTerm">
    </TableComponent>
  </div>
</template>

<script>
import TableComponent from "./Table/TableComponent.vue"
import optionsJSON from "@/data/select-options.json"
// Headers for table
import HomeJSON from "@/data/headers/home-head.json"
import GeneralInfoJSON from "@/data/headers/general-info-head.json"
import ConditionJSON from "@/data/headers/condition-head.json"
import TeamJSON from "@/data/headers/team-head.json"
import TimelinesJSON from "@/data/headers/timelines-head.json"
import CostJSON from "@/data/headers/cost-head.json"
import DocumentsJSON from "@/data/headers/documents-head.json"
import GoalsJSON from "@/data/headers/goals-head.json"
import MonitoringJSON from "@/data/headers/monitoring-head.json"

import api from "@/api"

export default {
  components: {
    TableComponent
  },
  data() {
    return {
      startURL: "/ProjectRegistry/Views",
      tableData: [],
      filteredData: [],
      tableHeadName: 'Home',
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
      options: optionsJSON,
      optionsHide: true,
      searchTerm: "",
      thisYearProjects: true,
      archiveProjects: false,
      portfolioProject: false,
    }
  },
  methods: {
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
        this.tableHead = headers
        URL = this.startURL + endURL
        const response = await api.getItemsJSON(URL)
        this.tableData = response.data
        this.filteredData = response.data
      } catch (error) {
        console.error('Error fetching items:', error)
      }
    },
    // Fetches home table data
    async fetchItemsHome() {
      this.tableHead = this.Home
      try {
        const URL = this.startURL + "/Home"
        const response = await api.getItemsJSON(URL)
        this.tableData = response.data
        this.filteredData = response.data
      } catch (error) {
        console.error('Error fetching items home:', error)
      }
      this.thisYearProjects = true
      this.archiveProjects = false  
      this.portfolioProject = false
      // call filter function
    },
    // Fetches table search result
    async fetchSearchResponse() {
      const URL = this.startURL + '/' + this.tableHeadName + "/Search?searchTerm=" + this.searchTerm
      try {
        const response = await api.getItemsJSON(URL)
        this.tableData = response.data
      } catch (error) {
        console.error('Error fetching search response:', error)
      }
    },
    // Updates checkbox filters
    async updateFilters() {
      console.log('ыыыыы')
    },
    // Grouping table data
    dataGrouping(option) {
      this.optionsHide = !this.optionsHide
      if (option === "Не группировать") {
        option = ''
        this.filteredData = this.tableData
      }
      const filterKey = option && option.toLowerCase()
      let data = this.tableData
      if (filterKey) {
        data = data.filter((row) => {
          return Object.keys(row).some((key) => {
            return String(row[key]).toLowerCase().indexOf(filterKey) > -1
          })
        })
      }
      return data
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
.custom-select {
  position: relative;
  font-family: Arial, sans-serif;
}
.select-selected {
  background-color: #2f4566;
  padding: 10px;
  cursor: pointer;
}
.select-items {
  position: absolute;
  background-color: white;
  border: 1px solid #ccc;
  z-index: 99;
  width: 150px;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2);
}
.select-items div {
  padding: 10px;
  cursor: pointer;
}
.select-items div:hover {
  background-color: #f1f1f1;
}
.select-hide {
  display: none;
}
.home-button {
  background-color: #9c1c1c;
}
.projects-table {
  padding: 5px 0;
}
</style>