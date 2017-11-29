/**
 * Created by Administrator on 2017/11/8.
 */
export default {
  readData(){
    return new Promise((resolve, reject) => {
      vueDevice.req('fingerPrint');
      vueDevice.exec(function (data) {
        resolve(data);
      }, function (error) {
        console.log(error);
        reject(error);
      });
    });
  },
}