<template>
  <div class="checkboxes">
    <input type="checkbox" v-model="thisYearProjects" @click="thisYearProjects = !thisYearProjects; updateFilters()" checked>Портфель проектов 2024
    <input type="checkbox" v-model="archiveProjects" @click="archiveProjects = !archiveProjects; updateFilters()">Архивные проекты
  </div>

  <div class="buttons">
    <div class="functional-buttons">
      <button>
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
      <button :class="{'picked-button': tableHead === ConditionView}" @click="fetchItems(ConditionView, 'ConditionView')">Состояние</button>
      <button :class="{'picked-button': tableHead === TeamView}" @click="fetchItems(TeamView, 'TeamView')">Команда проекта</button>
      <button :class="{'picked-button': tableHead === TimelinesView}" @click="fetchItems(TimelinesView, 'TimelinesView')">Сроки</button>
      <button :class="{'picked-button': tableHead === CostView}" @click="fetchItems(CostView, 'CostView')">Стоимость</button>
      <button :class="{'picked-button': tableHead === DocumentsView}" @click="fetchItems(DocumentsView, 'DocumentsView')">Документация</button>
      <button :class="{'picked-button': tableHead === GoalsView}" @click="fetchItems(GoalsView, 'GoalsView')">Цели</button>
    </div>
  </div>

  <div class="projects-table">
    <TableComponent
      :data="tableData"
      :columns="tableHead">
    </TableComponent>
  </div>
</template>

<script>
import TableComponent from "./Table/TableComponent.vue"

// Headers for table
import DefaultColumnsJSON from "@/data/default-head.json"
import GeneralInfoJSON from "@/data/general-info-head.json"
import ConditionViewJSON from "@/data/condition-view-head.json"
import TeamViewJSON from "@/data/team-view-head.json"
import TimelinesViewJSON from "@/data/timelines-view-head.json"
import CostViewJSON from "@/data/cost-view-head.json"
import DocumentsViewJSON from "@/data/documents-view-head.json"
import GoalsViewJSON from "@/data/goals-view-head.json"

import api from "@/api"

export default {
  components: {
    TableComponent
  },
  data() {
    return {
      DefaultColumns: DefaultColumnsJSON,
      tableData: [],
      tableHead: DefaultColumnsJSON,
      GeneralInfo: GeneralInfoJSON,
      ConditionView: ConditionViewJSON,
      TeamView: TeamViewJSON,
      TimelinesView: TimelinesViewJSON,
      CostView: CostViewJSON,
      DocumentsView: DocumentsViewJSON,
      GoalsView: GoalsViewJSON,
      searchQuery: "",
      thisYearProjects: true,
      archiveProjects: false,
      startURL: "/ProjectRegistry"
    }
  },
  methods: {
    goHome() {
      this.thisYearProjects = true
      this.archiveProjects = false  
      this.tableHead = this.defaultColumns
    },
    async fetchItems(headers, endURL) {
      try {
        let URL = ""
        if (headers === "search") {
          this.tableHead = this.defaultColumns
          URL = this.startURL + "?searchQuery=" + endURL 
          // on testing check the URL
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