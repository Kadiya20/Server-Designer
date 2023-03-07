import { createApp } from 'vue'
import axios from "axios";             // npm install axios

import App from './App.vue'
import router from './router'
import store from './store.js'
import process from 'node:process'
import PrimeVue from 'primevue/config';

import "primevue/resources/themes/fluent-light/theme.css"
import "primevue/resources/primevue.min.css"
import "primeicons/primeicons.css"
import './assets/main.css'

axios.defaults.baseURL = process.env.NODE_ENV == 'production' ? "/api" : "https://localhost:5001/api";

const app = createApp(App)
app.use(router)
app.use(store)
app.use(PrimeVue);
app.mount('#app')
