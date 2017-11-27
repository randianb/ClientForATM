export default {
  ini: function (_this,func) {
    let t = setInterval(function () {
      _this.time--;
      if (_this.time < 0) {
        clearInterval(t);
        func();
      }
    }, 1000);
  }
}