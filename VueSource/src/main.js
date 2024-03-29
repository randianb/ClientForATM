// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import modal from './plugin/modal'

Vue.use(modal);
Vue.config.productionTip = false;

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: {App},
  data: {
    dataHub: new Vue,
    dataContext: {errCode: 0},
    updateData: function (newData) {
      Object.assign(this.dataContext, newData);
      // console.log(this.dataContext);
    }
  },
});

