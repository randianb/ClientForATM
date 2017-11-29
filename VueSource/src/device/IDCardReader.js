export default {
  readData(){
    return new Promise((resolve, reject) => {
      vueDevice.req('IDCardReader');
      vueDevice.exec(function (data) {
        resolve(data);
      }, function (error) {
        reject(error);
      });
    });
  },
}