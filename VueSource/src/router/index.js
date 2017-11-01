import Vue from 'vue'
import Router from 'vue-router'
import Ads from '../components/Ads'
import TradeMenu from '../components/TradeMenu'

Vue.use(Router)

export default new Router({
  routes: [
    {path: '/', component: Ads},
    {path: '/TradeMenu', component: TradeMenu},
  ]
})
