<template>
  <div class="checkboxes">
    <input type="checkbox" v-model="thisYearProjects" @click="thisYearProjects = !thisYearProjects" checked>Портфель проектов 2024
    <input type="checkbox" v-model="archiveProjects" @click="archiveProjects = !archiveProjects">Архивные проекты
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
      <input @keydown.enter="search" v-model="searchQuery">
    </div>

    <div class="filter-buttons">
      <button class="home-button" @click="goHome">
        <img src="@/assets/svg/home.svg" width="16px" height="16px">
      </button>
      <button :class="{'picked-button': tableHead === generalInfo}" @click="tableHead = generalInfo">Общая информация</button>
      <button :class="{'picked-button': tableHead === states}" @click="tableHead = states">Состояние</button>
      <button :class="{'picked-button': tableHead === projectTeam}" @click="tableHead = projectTeam">Команда проекта</button>
      <button :class="{'picked-button': tableHead === deadlines}" @click="tableHead = deadlines">Сроки</button>
      <button :class="{'picked-button': tableHead === costs}" @click="tableHead = costs">Стоимость</button>
      <button :class="{'picked-button': tableHead === documents}" @click="tableHead = documents">Документация</button>
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

import defaultColumns from "@/data/default-head.json"
import tableData from "@/data/projects-table.json"
import generalInfo from "@/data/general-info-head.json"
import states from "@/data/states-head.json"
import projectTeam from "@/data/project-team-head.json"
import deadlines from "@/data/deadlines-head.json"
import costs from "@/data/cost-head.json"
import documents from "@/data/docs-head.json"

export default {
  components: {
    TableComponent
  },
  data() {
    return {
      defaultColumns: defaultColumns,
      tableData: tableData,
      tableHead: defaultColumns,
      generalInfo: generalInfo,
      states: states,
      projectTeam: projectTeam,
      deadlines: deadlines,
      costs: costs,
      documents: documents,
      searchQuery: "",
      thisYearProjects: true,
      archiveProjects: false
    }
  },
  methods: {
    search() {
      console.log(this.searchQuery)
      // request to backend
    },
    goHome() {
      this.thisYearProjects = true
      this.archiveProjects = false
      this.tableHead = this.defaultColumns
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