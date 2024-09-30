<template>
  <table v-if="filteredData.length">
    <thead>
      <tr>
        <th v-for="(value, key) in columns[0]"
          @click="sortBy(key)"
          :class="{ active: sortKey == key }">
          {{ capitalize(value) }}
          <span class="arrow" :class="sortOrders[key] > 0 ? 'asc' : 'dsc'">
          </span>
        </th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="(entry, index) in filteredData">
        <td v-for="key in Object.keys(columns[0])">
          <span v-if="key === 'id'">
            {{ incrementIndex(index) }}
          </span>
          <span v-else>
            {{ entry[key] }}
          </span>
        </td>
      </tr>
    </tbody>
  </table>
  <p v-else>Совпадений не найдено.</p>
</template>

<script>
export default {
  props: {
    data: Array,
    columns: Array
  },
  data() {
    return {
      sortKey: '',
      sortOrders: Object.keys(this.columns[0]).reduce((o, key) => ((o[key] = 1), o), {})
    }
  },
  computed: {
    filteredData() {
      const sortKey = this.sortKey
      const order = this.sortOrders[sortKey] || 1
      let data = this.data
      if (sortKey) {
        data = data.slice().sort((a, b) => {
          a = a[sortKey]
          b = b[sortKey]
          return (a === b ? 0 : a > b ? 1 : -1) * order
        })
      }
      return data
    }
  },
  methods: {
    sortBy(key) {
      this.sortKey = key
      this.sortOrders[key] = this.sortOrders[key] * -1
    },
    capitalize(str) {
      return str.charAt(0).toUpperCase() + str.slice(1)
    },
    incrementIndex(index) {
      return index + 1
    }
  }
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
  color: #ffffff;
  cursor: pointer;
  user-select: none;
}

td {
  background-color: #f9f9f9;
}

th,
td {
  min-width: 50px;
  font-size: 15px;
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
</style>