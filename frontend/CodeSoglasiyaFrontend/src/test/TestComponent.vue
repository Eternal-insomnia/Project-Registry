<template>
  <div>
    <h1>Items</h1>
    <ul v-for="item in items" :key="item.id">
      <li v-for="(col, key) in item">{{ key }} : {{ col }}</li>
    </ul>
    <button @click="fetchItems">Load Items</button>
    <button @click="addItem">Add Item</button>
  </div>
</template>

<script>
import api from '@/api';

export default {
  data() {
    return {
      items: [],
    };
  },
  methods: {
    async fetchItems() {
      try {
        const response = await api.getItems();
        this.items = response.data;
      } catch (error) {
        console.error('Error fetching items:', error);
      }
    },
    async addItem() {
      const newItem = { name: 'New Item' }; // Пример данных
      try {
        await api.createItem(newItem);
        this.fetchItems(); // Обновляем список после добавления
      } catch (error) {
        console.error('Error adding item:', error);
      }
    },
  },
};
</script>
