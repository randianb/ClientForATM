export default {
  readData(v){
    let _this = this;
    return new Promise((resolve, reject) => {
      vueDevice.req('IDCardReader');
      vueDevice.exec(function (data) {
        _this.refreshData(data,v);
        resolve(data);
      }, function (error) {
        reject(error);
      });
    });
  },
  // 更新数据上下文
  refreshData(data,v){
    v.$root.updateData(data);
  }
}