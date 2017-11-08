<template>
  <div id="app">
    <transition name="slide-fade">
      <router-view></router-view>
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
  font-family: 'Helvetica Neue', Helvetica, Arial, 'Microsoft Yahei', 'Hiragino Sans GB', 'Heiti SC', 'WenQuanYi Micro Hei', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  overflow: hidden;
}
.slide-fade-enter-active {
  transition: all .5s ease;
}
.slide-fade-leave-active {
  transition: all .5s ease;
}
.slide-fade-enter {
  transform: translateX(-100vw);
  opacity: 1;
}
.slide-fade-leave-to {
  transform: translateX(100vw);
  opacity: 1;
}
</style>
