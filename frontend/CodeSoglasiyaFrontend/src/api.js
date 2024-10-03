import axios from 'axios'

const baseURL = 'http://localhost:5000'
const timeout = 1000

const apiClientJSON = axios.create({
    baseURL: baseURL,
    timeout: timeout,
    headers: {
        'Content-Type': 'application/json',
    },
});
const apiClientFormData = axios.create({
    baseURL: baseURL,
    timeout: timeout,
    headers: {
        'Content-Type': 'multipart/form-data',
    }
})

export default {
    getItemsJSON(URL) {
        return apiClientJSON.get(URL);
    },
    createItemFormData(URL, data) {
        return apiClientFormData.post(URL, data);
    },
};