<template>
  <div id="app">
    <img src="../static/passbook.gif">
    <router-view></router-view>
  </div>
</template>

<script>
export default {
  name: 'app',
  created(){
    document.onkeypress=function (e) {
      if(e.keyCode==116){//f5
        console.log(e.keyCode);
      }
      if(e.keyCode==123){//f12
        console.log(e.keyCode);
      }
    }
  },
  methods:{
    dd(){
      alert('dd');
    },
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
