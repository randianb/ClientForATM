export default {
  // 倒计时时间（s）,超时函数,显示计时对象
  ini: function (time, timeoutF, _this) {
    let t = setInterval(function () {
      time--;
      if (_this) _this.time = time;
      if (time <= 0) {
        clearInterval(t);
        timeoutF();
      }
    }, 1000);
  }
}