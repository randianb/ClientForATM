/**
 * Created by Administrator on 2017/11/7.
 */
var export1={
  did:function () {
    var c = 0;
    console.log("export");
    return new Promise(function(resolve, reject){
      setTimeout(function () {
        for (var i = 0; i < 300000000; i++) {
          c++;
        }
        // var el=document.getElementById('cs');
        // el.addEventListener('device',function () {
          resolve(c);
        // });
        console.log("export2");
        // setTimeout(reject(c),2000);
      },0);
    });
  }
}
export default export1;