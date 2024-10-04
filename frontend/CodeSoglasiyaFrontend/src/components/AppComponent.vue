<template>
  <div class="app">
    <div class="banner">
      <a href="https://soglasietech.ru/">
        <img src="@/assets/svg/logo-soglasie.svg" alt="ЛОГО СОГЛАСИЕ">
      </a>
      <p>ПОРТАЛ<br>  ПРОЕКТНОГО УПРАВЛЕНИЯ</p>
    </div>
    <div class="menu">
      <button class="menu__button" :class="{'picked-button': currentComponent === 'MainPageComponent'}" @click="currentComponent = 'MainPageComponent'">
        Главная
      </button>
      <button class="menu__button" :class="{'picked-button': currentComponent === 'ProjectRegistryComponent'}" @click="currentComponent = 'ProjectRegistryComponent'">
        Реестр проектов
      </button>
      <button class="menu__button" :class="{'picked-button': currentComponent === 'LibraryComponent'}" @click="currentComponent = 'LibraryComponent'">
        Библиотека
      </button>
    </div>
    <div class="menu-page">
      <component :is="currentComponent"/>
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
  }
}
</script>

<style scoped>
.banner {
  width: 100%;
  min-height: 100px;
  background-image: url(@/assets/images/zaglushka.jpg);
  background-size: contain;
  display: flex;
  justify-content: space-between;
  align-items: center;
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