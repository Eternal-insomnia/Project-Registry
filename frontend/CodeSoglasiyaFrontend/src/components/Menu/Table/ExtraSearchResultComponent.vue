<template>
  <!-- <button @click="showLogs()">LOG</button> -->
  <div class="tables" v-for="(value, index) in tables" :key="index">
    <p v-if="filter != ''">Что-то нашлось в таблице {{ Object.keys(headers[index]) }}</p>
    <table v-if="filter != ''">
      <thead>
        <tr v-for="(value, key) in headers[index]" :key="key">
          <th v-for="(val, key) in value" :key="key">
            {{ val }}
          </th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(entry, i) in tables[index]" :key="i">
          <td v-for="key in deArray(headers[index])" :key="key" :class="{'abbreviated': contains(key)}" :title="entry[key]">
            <span v-if="key === 'num'">
              {{ incrementIndex(i) }}
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
import allHeaders from "@/data/headers/all-headers.json"
import abbreviatedJSON from '@/data/abbreviated.json'

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
      headers: allHeaders,
      abbreviated: abbreviatedJSON,
      hide: true,
    }
  },
  methods: {
    deArray(arr) {
      let key = Object.keys(arr)
      let arr1 = Object.keys(arr[key])
      return arr1
    },
    contains(elem) {
      for (var i = 0; i < this.abbreviated.length; i++) {
          if (this.abbreviated[i] === elem) {
              return true;
          }
      }
      return false;
    },
    async searchRequest(tableLink) {
      const URL = '/ProjectRegistry/Views' + tableLink + "/Search?searchTerm=" + this.filter
      try {
        const response = await api.getItemsJSON(URL)
        return response.data
      } catch (error) {
        console.error('Error fetching search response:', error)
      }
    },
    async showResults() {
      if (this.filter === '') {
        this.generalInfo = []
        this.condition = []
        this.team = []
        this.timelines = []
        this.cost = []
        this.documents = []
        this.goals = []
        this.monitoring = []
        this.notDisplayed = []
        return
      }
      this.generalInfo = await this.searchRequest("/GeneralInfo")
      this.condition = await this.searchRequest("/Condition")
      this.team = await this.searchRequest("/Team")
      this.timelines = await this.searchRequest("/Timelines")
      this.cost = await this.searchRequest("/Cost")
      this.documents = await this.searchRequest("/Documents")
      this.goals = await this.searchRequest("/Goals")
      this.monitoring = await this.searchRequest("/Monitoring")
      this.notDisplayed = await this.searchRequest("/NotDisplayed")
      this.tables = [this.generalInfo, this.condition, this.team, this.timelines, this.cost, this.documents, this.goals, this.monitoring, this.notDisplayed]
    },
    incrementIndex(index) {
      return index + 1
    },
    showLogs() {
      console.log(this.headers[0])
    }
  },
  watch: {
    filter() {
      this.showResults()
    }
  },
}
</script>

<style scoped>
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
.abbreviated {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
</style>