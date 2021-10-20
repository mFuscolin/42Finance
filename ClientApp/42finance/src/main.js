import vuetify from '@/plugins/vuetify'
import Vue from 'vue'
import api from './api'
import App from './App.vue'
import './components'
import router from './router'

Vue.config.productionTip = false
Vue.prototype.$api = api

new Vue({
  vuetify,
  router,
  render: h => h(App)
}).$mount('#app')
