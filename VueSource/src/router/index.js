import Vue from 'vue'
import Router from 'vue-router'
import Hello from '@/components/Hello'
import he from '@/components/he'

Vue.use(Router)

export default new Router({
  routes: [
    {path: '/', component: Hello},
    {path: '/he', component: he},
  ]
})
