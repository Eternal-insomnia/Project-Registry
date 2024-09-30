import axios from 'axios'

const apiClient = axios.create({
    baseURL: 'http://localhost:5265',
    timeout: 1000,
    headers: {
        'Content-Type': 'application/json',
    },
});

export default {
    getItems() {
        return apiClient.get('/items');
    },
    createItem(data) {
        return apiClient.post('/items', data);
    },
    updateItem(id, data) {
        return apiClient.put(`/items/${id}`, data);
    },
    deleteItem(id) {
        return apiClient.delete(`/items/${id}`);
    },
};