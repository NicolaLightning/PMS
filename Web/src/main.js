// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import Vuex from 'vuex'
import App from './App'
import router from './router'
import ElementUI from 'element-ui'
import store from './store'
import 'element-ui/lib/theme-chalk/index.css'
import '@/permission' // permission control

Vue.config.productionTip = false
Vue.use(ElementUI)
Vue.use(Vuex)
if (process.env.NODE_ENV === 'development') {
  const { mockXHR } = require('./mock')
  mockXHR()
}

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  store,
  components: { App },
  template: '<App/>'
})
