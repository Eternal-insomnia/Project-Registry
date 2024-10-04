<template>
  <div class="app">
    <div class="banner">
      <a href="https://soglasietech.ru/">
        <img src="@/assets/svg/logo-soglasie.svg" alt="ЛОГО СОГЛАСИЕ">
      </a>
      <p class="banner__p">ПОРТАЛ<br>  ПРОЕКТНОГО УПРАВЛЕНИЯ</p>
    </div>
    <div class="menu">
      <button class="menu__button" :class="{'picked-button': currentComponent === 'MainPageComponent'}" @click="currentComponent = 'MainPageComponent'">
        Главная
      </button>
      <button class="menu__button" :class="{'picked-button': currentComponent === 'ProjectRegistryComponent'}" @click="currentComponent = 'ProjectRegistryComponent'; clickHome()">
        Реестр проектов
      </button>
      <button class="menu__button" :class="{'picked-button': currentComponent === 'LibraryComponent'}" @click="currentComponent = 'LibraryComponent'">
        Библиотека
      </button>
    </div>
    <div class="menu-page">
      <component ref="homeClick" :is="currentComponent"/>
    </div>
  </div>
</template>

<script>
import LibraryComponent from './Menu/LibraryComponent.vue';
import MainPageComponent from './Menu/MainPageComponent.vue';
import ProjectRegistryComponent from './Menu/ProjectRegistryComponent.vue';

export default {
  components: {
    LibraryComponent,
    MainPageComponent,
    ProjectRegistryComponent
  },
  data() {
    return {
      currentComponent: "MainPageComponent"
    }
  },
  methods: {
    clickHome() {
      setTimeout(() => {
        this.$refs.homeClick.fetchItemsHome()
      }, 10)
    }
  }
}
</script>

<style scoped>
.banner {
  width: 100%;
  min-height: 100px;
  /* background-image: url(@/assets/images/zaglushka.jpg); */
  background-color: #cdf;
  background-size: contain;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.banner__p {
  margin-right: 20px;
}
.menu {
  display: flex;
  justify-content: center;
  padding: 5px;
  margin: 20px;
}
.menu__button {
  margin: 0 10px;
  min-width: 150px;
  min-height: 40px;
}
</style>