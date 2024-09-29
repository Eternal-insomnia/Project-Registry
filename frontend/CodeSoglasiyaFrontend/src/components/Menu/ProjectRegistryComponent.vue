<template>
  <p>Реестр проектов</p>
  <div class="filters">
    <input type="checkbox">Портфель проектов 2024
    <input type="checkbox">Архивные проекты
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
      <input @keydown.enter="(event) => searchQuery = event.target.value">
    </div>

    <div class="filter-buttons">
      <button class="home-button">
        <img src="@/assets/svg/home.svg" width="16px" height="16px">
      </button>
      <button @click="console.log('Общая информация')">Общая информация</button>
      <button @click="console.log('Состояние')">Состояние</button>
      <button @click="console.log('Команда проекта')">Команда проекта</button>
      <button @click="console.log('Сроки')">Сроки</button>
      <button @click="console.log('Стоимость')">Стоимость</button>
      <button @click="console.log('Документация')">Документация</button>
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

import tableData from "@/data/projects-table.json"
import tableHead from "@/data/general-info-head.json"

export default {
  components: {
    // TableComponent,
    TableComponent
  },
  data() {
    return {
      searchQuery: "",
      tableData: tableData,
      tableHead: tableHead
    }
  },
  methods: {
    search(event) {
      event.target
    }
  }
}
</script>

<style scoped>
.buttons {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  background-color: #5f9ea0;
}
.functional-buttons {
  display: flex;
  flex-direction: row;
  align-items: end;
}
.home-button {
  background-color: #9c1c1c;
}
.projects-table {
  background-color: #29da12;
}
</style>