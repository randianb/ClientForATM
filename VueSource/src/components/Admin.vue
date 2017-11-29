<template>
  <div class="admin">
    <head-v></head-v>

    <div class="box">
      <button @click="exitApp">退出系统</button>
    </div>

    <foot-v></foot-v>
  </div>
</template>

<script>

  import Head from './Head'
  import Foot from './Foot'

  export default {
    name: 'admin-menu',
    components: {
      'head-v': Head,
      'foot-v': Foot,
    },
    data() {
      return {
        showButton: true
      };
    },
    methods: {
      exitApp(){
        vueDevice.req('shutdown','tcp','http://bilibili.com');
      },
    },
  };

</script>

<style scoped>
  button{
    margin-top: 150px;
  }
  .admin {
    background-color: rgba(0, 0, 0, .3);
    width: 100vw;
    height: 100vh;
  }

  .box {
    width: 600px;
    height: 400px;
    border-radius: 8px;
    margin: auto;
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: white;
  }
</style>
