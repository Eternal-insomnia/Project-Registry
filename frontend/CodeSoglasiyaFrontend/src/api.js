import axios from 'axios'

const apiClient = axios.create({
    baseURL: 'http://localhost:5000',
    timeout: 1000,
    headers: {
        'Content-Type': 'application/json',
    },
});

export default {
    getItems() {
        return apiClient.get('/ProjectRegistry/ProjectsGeneralInfo');
    },
    createItem(data) {
        return apiClient.get('/items', data);
    },
};