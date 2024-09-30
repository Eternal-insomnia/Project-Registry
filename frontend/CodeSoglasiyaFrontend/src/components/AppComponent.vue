<template>
  <div class="app">
    <div class="banner">
      <img src="@/assets/images/zaglushka.jpg">
    </div>
    <div class="menu">
      <button :class="{'picked-button': currentComponent === 'MainPageComponent'}" @click="currentComponent = 'MainPageComponent'">
        Главная
      </button>
      <button :class="{'picked-button': currentComponent === 'ProjectRegistryComponent'}" @click="currentComponent = 'ProjectRegistryComponent'">
        Реестр проектов
      </button>
      <button :class="{'picked-button': currentComponent === 'LibraryComponent'}" @click="currentComponent = 'LibraryComponent'">
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
  max-height: 100px;
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