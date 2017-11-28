export default new function () {
  // 倒计时时间（s）,超时函数,显示计时对象
  let t;
  let _this = this;
  this.Ini = function (time, timeoutCallBack, v) {
    _this.resetF = false;
    let SumTime = time;
    t = setInterval(function () {
      time--;
      if (_this.resetF) {
        time = SumTime;
        _this.resetF = false;
      }
      if (v) {
        v.time = time;
      }
      if (time <= 0) {
        // console.log(time + ':' + _this.stopF);
        clearInterval(t);
        timeoutCallBack();
      }
    }, 1000);
  }
  this.stop = function () {
    clearInterval(t);
  }
  this.reset=function () {
    _this.resetF=true;
  }
}