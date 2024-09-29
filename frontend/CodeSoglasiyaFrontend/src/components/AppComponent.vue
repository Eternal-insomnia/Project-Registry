<template>
  <div class="app">
    <div class="banner">
      <img src="@/assets/images/zaglushka.png">
    </div>
    <div class="menu">
      <button @click="currentComponent = 'MainPageComponent'">
        Главная
      </button>
      <button @click="currentComponent = 'ProjectRegistryComponent'">
        Реестр проектов
      </button>
      <button @click="currentComponent = 'LibraryComponent'">
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
      currentComponent: "ProjectRejistryComponent"
    }
  }
}
</script>

<style scoped>
.app {
  background-color: #00ffff;
}
.menu-page {
  background-color: #ff7f50;
}
</style>