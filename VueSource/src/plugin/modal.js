import modal from './vue/modal'

export default {
  install: function (Vue, option = {}) {
    let div = Vue.extend(modal);
    let com = new div().$mount();
    let _this = this;
    this.show = false;
    Vue.prototype.$modal = function (msg, ok_btn, cancel_btn, no_btn) {
      document.body.appendChild(com.$el);
      com.$data.show = true;
      com.$data.msg = msg;
    }
  }
}