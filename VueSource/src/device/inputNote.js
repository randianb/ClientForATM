/**
 * Created by Administrator on 2017/11/7.
 */
export default {
  depositCash(v){
    let _this = this;
    return new Promise((resolve, reject) => {
      vueDevice.req('IDCardreader');
      vueDevice.exec(function (data) {
        _this.refreshData(data,v);
        resolve(data);
      }, function (error) {
        console.log(error);
        reject(error);
      });
    });
  },
  // 更新数据上下文
  refreshData(data,v){
    v.$root.updateData(data);
  }
}