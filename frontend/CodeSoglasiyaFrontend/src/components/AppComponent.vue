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
      currentComponent: "MainPageComponent"
    }
  }
}
</script>

<style scoped>
.banner img{
  width: 100%;
}
.menu {
  display: flex;
  justify-content: center;
  padding: 5px;
}
.menu button {
  margin: 0 10px;
  min-width: 150px;
  min-height: 40px;
}
</style>