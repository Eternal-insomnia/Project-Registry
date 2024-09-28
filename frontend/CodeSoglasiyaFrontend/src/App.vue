<template>
  <main>
    <div class="application-container">
      <AppComponent/>
      <!-- <TestComponent/> -->
    </div>
  </main>
</template>

<script>
import AppComponent from "./components/AppComponent.vue";
//import TestComponent from "./test/TestComponent.vue";

export default {
  components: {
    AppComponent
    //TestComponent
  }
}
</script>

<style>
</style>
