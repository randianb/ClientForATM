import Vue from 'vue'
import Router from 'vue-router'
import Ads from '../components/Ads'
import TradeMenu from '../components/TradeMenu'
import AdminMenu from '../components/AdminMenu'
import StepNavigator from '../components/StepNavigator'

Vue.use(Router)

export default new Router({
  routes: [
    { path: '/', component: Ads },
    { path: '/TradeMenu', component: TradeMenu },
    { path: '/admin-menu', component: AdminMenu },
    { path: '/step-navigator/:name/:code', component: StepNavigator },
    // { path: '/Admin-page-navigator/:name/:code', component: AdminPageNavigator }

  ]
})
