export default {
  depositCash(){
    return new Promise((resolve, reject) => {
      vueDevice.req('inputNote');
      vueDevice.exec(function (data) {
        resolve(data);
      }, function (error) {
        console.log(error);
        reject(error);
      });
    });
  },
}