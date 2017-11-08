/**
 * Created by Administrator on 2017/11/8.
 */
export default {
  did:function () {
    console.log("export");
    return new Promise(function(resolve, reject){
      var el=document.getElementById('cs');
      el.addEventListener('device',function () {
        resolve(()=>{return 132});
      });
    });
  }
}