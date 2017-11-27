import modalO from './vue/modal'

// modal 参数 modal(图标，信息正文，确定按钮函数，取消按钮函数，倒计时时间)

export default {
  install: function (Vue, option = {}) {
    let div = Vue.extend(modalO);
    let modal = new div().$mount();
    this.show = false;
    Vue.prototype.$modal = function (obj) {
      document.getElementById('app').appendChild(modal.$el);
      let def = {
        a: 'a',
        msg: '',
        img: 'yes',
        no_btn: undefined,
        yes_btn: function () {
        },
        time: 0
      };
      Object.assign(def, obj);
      modal.$data.show = true;
      modal.$data.msg = def.msg;
      if (def.no_btn == undefined) {
        modal.$data.Dbutton = false;
      }
      if (def.msg == '')
        console.error('[plugin modal]：invalid message content');
      modal.$data.yes_fun = def.yes_btn;
      modal.$data.no_fun = def.no_btn;
      modal.$data.time = def.time;
      modal.$data.img = def.img;
      modal.$data.startup();
    }
  }
}