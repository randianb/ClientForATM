<template>
  <div class="container">
    <header-view></header-view>
    <div class="content"></div>
    <img src="../../static/trademenu/HandyServices.png" alt="">
    <footer-view></footer-view>
  </div>
</template>
<script>
  import t from  '../device/test'
  import TradeMenu from  './TradeMenuData'
  import Head from './Head'
  import Foot from './Foot'

  export default {
    name: 'hell',
    components:{
      'header-view':Head,
      'footer-view':Foot,
    },
    data () {
      return {
        msg: 'default',
        second:'',
        flag:true,
        tradeMenu:TradeMenu,
      }
    },
    methods:{
      async read () {

      },
      b(){
        console.log(this.tradeMenu);
      },

    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .container{
    width: 100vw;
    height: 100vh;
  }
    h1, h2 {
        font-weight: normal;
        cursor: pointer;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
        background-color: yellow;
    }

    a {
        color: #42b983;
    }
</style>
