import axios from 'axios'

const apiClient = axios.create({
    baseURL: 'http://localhost:5000',
    timeout: 1000,
    headers: {
        'Content-Type': 'application/json',
    },
});

export default {
    getItems(URL) {
        return apiClient.get(URL);
    },
    createItem(URL) {
        return apiClient.get(URL);
    },
};