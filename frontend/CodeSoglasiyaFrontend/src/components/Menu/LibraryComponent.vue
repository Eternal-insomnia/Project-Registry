<template>
  <p>Библиотека</p>
  <table>
    <th>

    </th>
    <td>

    </td>
  </table>
</template>  

<script>
import api from '@/api'
import AllHeadersJSON from '@/data/headers/all-headers.json'

export default {
  data() {
    return {
      AllHeaders: AllHeadersJSON,
      projectData: []
    }
  }
}
</script>