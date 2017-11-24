<template>
  <div v-if="show" class="modal">
    <div class="box">
      <img src="../../../static/trade/checkFail.png" alt="">
      <div class="msg">{{msg}}</div>
      <button @click="hide">确定</button>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {
        show: false,
        msg:'',
      }
    },
    methods: {
      hide(){
        this.show = false;
      },
    },
    computed: {},
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .modal {
    width: 100vw;
    height: 100vh;
    background-color: rgba(0, 0, 0, .3);
    position: absolute;
    top: 0;
    left: 0;
  }
  .box{
    padding-top:20px ;
    text-align: center;
    font-size: 26px;
    border-radius: 6px;
    background-color: white;
    display: inline-block;
    position: absolute;
    left: 0;
    right: 0;
    top:0;
    bottom: 0;
    margin: 0 auto;
    width: 500px;
    height: 200px;
  }
  img{
    display: block;
    width: 40px;
    height: 40px;
    margin: 10px  auto;
    border-style: none;
  }
  .msg{
    text-align: center;
    margin: 20px 0 10px;
    max-width: 400px;
  }
  button{
    height: 36px;
    width: 110px;
    font-size: 22px;
    position: absolute;
    bottom: 20px;
    margin: 0;
    right: 50px;
  }
</style>
