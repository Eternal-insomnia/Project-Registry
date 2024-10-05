<template>
  <p @click="showResults()">Нашлось ещё кое-что</p>
</template>

<script>
import api from "@/api"

export default {
  props: {
    filter: String
  },
  data() {
    return {
      generalInfo: [],
      condition: [],
      team: [],
      timelines: [],
      cost: [],
      documents: [],
      goals: [],
      monitoring: [],
      notDisplayed: [],
    }
  },
  methods: {
    async searchRequest(tableLink) {
      const URL = '/ProjectRegistry/Views' + tableLink + "/Search?searchTerm=" + this.filter
      try {
        const response = await api.getItemsJSON(URL)
        console.log(response.data)
        return response.data
      } catch (error) {
        console.error('Error fetching search response:', error)
      }
    },
    showResults() {
      this.generalInfo = this.searchRequest("/GeneralInfo")
      this.condition = this.searchRequest("/Condition")
      this.team = this.searchRequest("/Team")
      this.timelines = this.searchRequest("/Timelines")
      this.cost = this.searchRequest("/Cost")
      this.documents = this.searchRequest("/Documents")
      this.goals = this.searchRequest("/Goals")
      this.monitoring = this.searchRequest("/Monitoring")
      this.notDisplayed = this.searchRequest("/NotDisplayed")
    }
  }
}
</script>