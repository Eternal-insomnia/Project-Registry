<template>
  <div class="main-page">
    <button class="import-button" @click="console.log('АХАХАХАХХАХАХАХ')">
      Импортировать проект
    </button>
  </div>
  <test/>
</template>

<script>
import test from "@/test/TestComponent.vue"

export default {
  components: {
    test
  }
}
</script>

<style scoped>
.main-page {
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 10px;
}
.import-button {
  height: 40px;
  width: 180px;
}
</style>