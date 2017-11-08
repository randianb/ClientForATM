import Vue from 'vue'
import Router from 'vue-router'
import Ads from '@/components/ads'
import he from '@/components/he'

Vue.use(Router)

export default new Router({
  routes: [
    {path: '/', component: Ads},
    {path: '/he', component: he},
  ]
})
