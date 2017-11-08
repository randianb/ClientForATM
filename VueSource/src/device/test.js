/**
 * Created by Administrator on 2017/11/7.
 */
var export1={
  did:function () {
    console.log("export");
    return new Promise(function(resolve, reject){
      var el=document.getElementById('cs');
      el.addEventListener('device',function () {
        resolve(()=>{return 'resolve'});
      });
    });
  }
}
export default export1;