const BASE_URL = 'http://localhost:5000';

export default {
    get: (endpoint, callback) => 
        fetch(BASE_URL + endpoint)
            .then(data => data.json())
            .then(data => callback(data))
            .catch(console.log)
}