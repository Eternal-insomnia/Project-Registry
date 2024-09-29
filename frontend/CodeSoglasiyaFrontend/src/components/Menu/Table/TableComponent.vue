<template>
  Ваша таблица
  <table>
    <thead>
      <tr>
        <th v-for="header in headers" :key="header">
          {{ header }}
        </th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="project in projects" :key="project.id">
        <td v-for="state in project" :key="state">{{ state }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
import tableData from "@/data/projects-table.json"
import tableHead from "@/data/general-info-head.json"

export default {
  data() {
    return {
      projects: tableData,
      headers: tableHead
    }
  }
}
// В папке с таблицами
</script>

<style>
table {
  text-align: left;
}
tr {
  height: 15px;
}
</style>