import Vue from 'vue'
import Router from 'vue-router'
import Ads from '../components/Ads'
import TradeMenu from '../components/TradeMenu'
import AdminMenu from '../components/Admin'
import StepNavigator from '../components/StepNavigator'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {path: '/', component: Ads},
    {path: '/TradeMenu', component: TradeMenu},
    {path: '/Admin', component: AdminMenu},
    {path: '/step-navigator/:name/:code', name: 'StepNavigator', component: StepNavigator},
  ]
})
