<template>
  <div id="app">
    <transition name="slider">
      <router-view key="app"></router-view>
    </transition>
  </div>
</template>

<script>
  export default {
  name: 'app',
  created(){
    var url=location.href;
    document.onkeypress=function (e) {
      console.log(e.keyCode);
      if(e.keyCode==116){//f5
        this.$router.push('/')
        console.log(e.keyCode);
      }
      if(e.keyCode==123){//f12
        console.log(e.keyCode);
      }
      if(e.keyCode==61){//+
        location.href=url.split('#')[0];
      }
    }
  },
//  mounted:{
//    jumpAd(){
//      alert();
////      document.vue.$router.push('/');
//    }
//  }
}
</script>

<style>
  body{
    margin: 0;
    padding: 0;
  }
  #app {
    position: relative;
    font-family: "Microsoft Yahei", Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
    overflow: hidden;
  }
  .slider-enter-active {
    position: absolute;
    top:0;
    transition: all .5s ease;
  }
  .slider-leave-active {
    position: absolute;
    top:0;
    transition: all .5s ease;
  }
  .slider-enter {
    position: absolute;
    top:0;
    transform: translateX(-100vw);
    opacity: 1;
  }
  .slider-enter-to {
    position: absolute;
    top:0;
    left:0;
  }
  .slider-leave{
    position: absolute;
    top:0;
  }
  .slider-leave-to {
    position: absolute;
    top:0;
    transform: translateX(100vw);
    opacity: 1;
  }
</style>
