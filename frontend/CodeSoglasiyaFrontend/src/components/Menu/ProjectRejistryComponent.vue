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
      <input @keydown.enter="(event) => searchRequest = event.target.value">
    </div>

    <div class="filter-buttons">
      <button class="home-button">
        <img src="@/assets/svg/home.svg" width="16px" height="16px">
      </button>
      <button>Общая информация</button>
      <button>Состояние</button>
      <button>Команда проекта</button>
      <button>Сроки</button>
      <button>Стоимость</button>
      <button>Документация</button>
    </div>
  </div>

  <div class="projects-table">
    <!-- Сделать нормальную таблицу через v-for в отдельном компоненте -->
    Тут могла быть ваша таблица, но вы не передали JSON
  </div>
</template>

<script>
export default {
  data() {
    return {
      searchRequest: ""
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
.home-button {
  background-color: #9c1c1c;
}
.projects-table {
  background-color: #29da12;
}
</style>