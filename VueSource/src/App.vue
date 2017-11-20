<template>
  <div id="app">
    <transition name="slider">
      <router-view></router-view>
    </transition>
  </div>
</template>

<script>
  export default {
  name: 'app',
  mounted(){
  },
}
</script>

<style>
  button{
    width: 170px;
    height: 50px;
    font-size: 24px;
    color: white;
    background-color: #e74a41;
    border-radius: 8px;
    border: 2px solid #e74a41;
    display: inline-block;
    margin: 0 50px 0;
  }
  .clearfix::after{
    content: '';
    clear: both;
    display: block;
  }
  body{
    margin: 0;
    padding: 0;
  }
  #app {
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
