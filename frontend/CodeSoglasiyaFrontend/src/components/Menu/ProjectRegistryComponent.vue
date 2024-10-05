<template>
  <div class="checkboxes">
    <input type="checkbox" v-model="thisYearProjects" @change="filteredData = dataGrouping(currentOption)" checked>Портфель проектов 2024
    <input type="checkbox" v-model="archiveProjects" @change="filteredData = dataGrouping(currentOption)">Архивные проекты
    <input type="checkbox" v-model="portfolioProject" @change="filteredData = dataGrouping(currentOption)">Проект портфеля 2024
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
          <div v-for="option in options" :key="option" @click="filteredData = dataGrouping(option); currentOption = option">
            {{ option }}
          </div>
        </div>
      </div>
      Поиск:
      <input @keydown.enter="fetchSearchResponse()" v-model="searchTerm">
    </div>

    <div class="filter-buttons">
      <button class="home-button" @click="fetchItemsHome(); tableHeadName = Home; currentTable = 'Home'">
        <img src="@/assets/svg/home.svg" width="16px" height="16px">
      </button>
      <button 
        :class="{'picked-button': tableHead === GeneralInfo}" 
        @click="fetchItems(GeneralInfo, '/GeneralInfo'); tableHeadName = GeneralInfo; currentTable = 'GeneralInfo'"
      >
        Общая информация
      </button>
      <button 
        :class="{'picked-button': tableHead === Condition}"
        @click="fetchItems(Condition, '/Condition'); tableHeadName = Condition; currentTable = 'Condition'"
      >
        Состояние
      </button>
      <button 
        :class="{'picked-button': tableHead === Team}" 
        @click="fetchItems(Team, '/Team'); tableHeadName = Team; currentTable = 'Team'"
      >
        Команда проекта
      </button>
      <button 
        :class="{'picked-button': tableHead === Timelines}" 
        @click="fetchItems(Timelines, '/Timelines'); tableHeadName = Timelines; currentTable = 'Timelines'"
      >
        Сроки
      </button>
      <button 
        :class="{'picked-button': tableHead === Cost}" 
        @click="fetchItems(Cost, '/Cost'); tableHeadName = Cost; currentTable = 'Cost'"
      >
        Стоимость
      </button>
      <button 
        :class="{'picked-button': tableHead === Documents}" 
        @click="fetchItems(Documents, '/Documents'); tableHeadName = Documents; currentTable = 'Documents'"
      >
        Документация
      </button>
      <button 
        :class="{'picked-button': tableHead === Goals}" 
        @click="fetchItems(Goals, '/Goals'); tableHeadName = Goals; currentTable = 'Goals'"
      >
        Цели
      </button>
      <button 
        :class="{'picked-button': tableHead === Monitoring}" 
        @click="fetchItems(Monitoring, '/Monitoring'); tableHeadName = Monitoring; currentTable = 'Monitoring'"
      >
        Мониторинг
      </button>
    </div>
  </div>

  <div class="projects-table">
    <TableComponent
      :data="filteredData"
      :columns="tableHead"
      :filter-key="searchTerm"
    >
    </TableComponent>
  </div>
  <!-- <ExtraSearchResultComponent
    :filter="searchTerm"
  >
  </ExtraSearchResultComponent> -->
</template>

<script>
import TableComponent from "./Table/TableComponent.vue"
import ExtraSearchResultComponent from "./Table/ExtraSearchResultComponent.vue"

// Headers for table
import optionsJSON from "@/data/select-options.json"
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
    TableComponent,
    ExtraSearchResultComponent
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
      currentOption: 'Не группировать',
      currentTable: 'Home',
      optionsHide: true,
      extraInfoHide: true,
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
        const LINK = "/ProjectRegistry/Views/" + this.currentTable + "/Export"
        const response = await api.apiClientExportFile(LINK)
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
      this.filteredData = this.dataGrouping(this.currentOption)
    },
    // Fetches home table data
    async fetchItemsHome() {
      this.tableHead = this.Home
      try {
        const URL = this.startURL + "/Home"
        const response = await api.getItemsJSON(URL)
        this.tableData = response.data
      } catch (error) {
        console.error('Error fetching items home:', error)
      }
      this.thisYearProjects = true
      this.archiveProjects = false  
      this.portfolioProject = false
      this.filteredData = this.dataGrouping(this.currentOption)
    },
    // Fetches table search result
    async fetchSearchResponse() {
      // change ExtraSearchResultComponent visibility
    },
    // Searching data
    dataFilter(data, filter) {
      console.log(data, filter)
      if (filter) {
        data = data.filter((row) => {
          return Object.keys(row).some((key) => {
            return String(row[key]).toLowerCase().indexOf(filter) > -1
          })
        })
        return data
      }
    },
    // Searching year by the current year
    yearFilter(data) {
      let filteredData = []
      let index = 0
      for(let project in data) {
        if (data[project].year === '24') {
          filteredData[index] = data[project]
          index++
        }
      }
      return data = filteredData
    },
    // Searching status by the filter
    statusFilter(data, filter) {
      let filteredData = []
      let index = 0
      for(let project in data) {
        if (data[project].status.toLowerCase() === filter.toLowerCase()) {
          filteredData[index] = data[project]
          index++
        }
      }
      return data = filteredData
    },
    // Searching data with filters
    dataGrouping(option) {
      this.optionsHide = true
      let data = this.tableData
      let filter = option.toLowerCase()
      if (option !== "Не группировать") {
        data = this.dataFilter(data, filter)
      }
      if (this.thisYearProjects) {
        data = this.yearFilter(data)
      }
      if (this.archiveProjects) {
        filter = 'архив'
        data = this.statusFilter(data, filter)
      }
      if (this.portfolioProject) {
        filter = 'проектная инициатива'
        data = this.statusFilter(data, filter)
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