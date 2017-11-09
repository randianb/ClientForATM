<template>
  <div class="container">
    <header-view></header-view>
    <div class="content" @mousedown="down" @mouseup="up">
      <nav>
        <button class="btn1">返回上一级</button>
        <button class="btn2">退出</button>
      </nav>
      <article>
<!--180 15 20-->
        <div class="ele">
          <img src="../../static/trademenu/HandyServices.png" alt="">
          <br>
          <span>账户管理</span>
        </div>

      </article>
    </div>

    <footer-view></footer-view>
  </div>
</template>
<script>
  import t from  '../device/test'
  import TradeMenu from './TradeMenuData.json'
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
        Xaxis:0,
        page:0,
      }
    },
    created(){
    },
    methods:{
      down(e){
        this.Xaxis=e.screenX;
      },
      up(e){
        if(200<this.Xaxis-e.screenX){
          this.page++;
        }
        if(200>this.Xaxis-e.screenX){
          this.page--;
        }
      },
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
  button{
    width: 85px;
    height: 35px;
    font-size: 18px;
    color: white;
    background-color: #e74a41;
    border-radius: 8px;
    border: 0;
    display: block;
    margin:0 50px;
  }
  .btn2{
    float: right;
  }
  .btn1{
    width: 135px;
    float: left;
  }
  nav{
    height: 35px;
    width: 100%;
    margin: 20px 0;
  }
  article{
    width: 1000px;
    margin: 0 auto;
  }
  .container{
    background-color: #f5f9ed;
    width: 100vw;
    height: 100vh;
  }
  .ele{
    font-weight: bold;
    padding-top: 20px;
    box-shadow: 0px 0px 13px 5px rgba(0,0,0,0.1);
    border-radius: 4px;
    width: 180px;
    height: 180px;
    background-color: white;
    margin: 0 8px 20px ;
    display: inline-block;
  }
  .ele img{
    width: 100px;
    height: 100px;
  }
  .ele span{
    display: inline-block;
    font-size: 20px;
    margin-top: 12px;
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
