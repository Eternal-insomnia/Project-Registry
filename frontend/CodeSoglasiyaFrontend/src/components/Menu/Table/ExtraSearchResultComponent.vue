<template>
  <div v-for="table in tables" :key="table" :class="{'hide': hide}">
    <p v-if="filter !== ''"></p>
    <table v-if="filter !== ''">
      <thead>
        <tr>
          <th v-for="(value, key) in table[0]" :key="value.id"
            @click="sortBy(key)"
            :class="{ active: sortKey == key }">
            {{ capitalize(value) }}
            <span class="arrow" :class="sortOrders[key] > 0 ? 'asc' : 'dsc'">
            </span>
          </th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(entry, index) in filteredData" :key="index">
          <td v-for="key in Object.keys(columns[0])" :key="key" :class="{'abbreviated': contains(key)}" :title="entry[key]">
            <span v-if="key === 'num'">
              {{ incrementIndex(index) }}
            </span>
            <span v-else>
              {{ entry[key] }}
            </span>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import api from "@/api"
import GeneralInfoJSON from "@/data/headers/general-info-head.json"
import ConditionJSON from "@/data/headers/condition-head.json"
import TeamJSON from "@/data/headers/team-head.json"
import TimelinesJSON from "@/data/headers/timelines-head.json"
import CostJSON from "@/data/headers/cost-head.json"
import DocumentsJSON from "@/data/headers/documents-head.json"
import GoalsJSON from "@/data/headers/goals-head.json"
import MonitoringJSON from "@/data/headers/monitoring-head.json"
import NotDisplayedJSON from "@/data/headers/not-displayed.json"

export default {
  props: {
    filter: String,
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
      tables: [this.generalInfo, this.condition, this.team, this.timelines, this.cost, this.documents, this.goals, this.monitoring, this.notDisplayed],
      GeneralInfoHead: GeneralInfoJSON,
      ConditionHead: ConditionJSON,
      TeamHead: TeamJSON,
      TimelinesHead: TimelinesJSON,
      CostHead: CostJSON,
      DocumentsHead: DocumentsJSON,
      GoalsHead: GoalsJSON,
      MonitoringHead: MonitoringJSON,
      NotDisplayedHead: NotDisplayedJSON,
      hide: true,
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
      if (this.filter === '') {
        this.hide = true
      } else { this.hide = false }
      console.log(this.hide)
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
  },
  watch: {
    filter() {
      this.showResults()
    }
  },
}
</script>

<style>
table {
  border-radius: 3px;
  background-color: #969696;
  width: 100%;
}
th {
  background-color: #42b983;
  color: #eee;
  cursor: pointer;
  user-select: none;
}
td {
  background-color: #f9f9f9;
  text-align: center;
  max-height: 15px;
  max-width: 100px;
}
th,
td {
  min-width: 50px;
  font-size: 11px;
}
th.active {
  color: #fff;
}
th.active .arrow {
  opacity: 1;
}
.arrow {
  display: inline-block;
  vertical-align: middle;
  width: 0;
  height: 0;
  margin-left: 5px;
  opacity: 0.66;
}
.arrow.asc {
  border-left: 4px solid transparent;
  border-right: 4px solid transparent;
  border-bottom: 4px solid #fff;
}
.arrow.dsc {
  border-left: 4px solid transparent;
  border-right: 4px solid transparent;
  border-top: 4px solid #fff;
}
.hide {
  display: none;
}
</style>