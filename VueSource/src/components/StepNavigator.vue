<template>
  <div class="container">
    <header-view></header-view>

    <div class="content">
      <aside>
        <div class="list">
          <div class="item" :class="{todo:(step<index)}" v-for="(item ,index) in steps">
            <span class="num">{{index+1}}</span>
            <span class="div"></span>
            <span class="name">{{item.name}}</span>
          </div>
        </div>
        <button @click="msg"><img src="../../static/trade/home.png"> &nbsp;返回</button>
      </aside>
      <section>
        <div class="title">{{this.$route.params.name}}</div>
        <div class="page-body">
          <comp-body @dataHub="alert('f')" :dataContext="tradeData" :compName="steps[step].modules"></comp-body>
        </div>
      </section>
    </div>

    <!--<footer-view></footer-view>-->
  </div>
</template>

<script>
  import t from '../device/test'
  import Head from './Head'
  import Foot from './Foot'
  import CompBody from '../modules/shared/compBody'

  export default {
    name:'StepNavigator',
    components:{
      'compBody': CompBody,
      'header-view':Head,
      'footer-view':Foot,
    },
    data () {
      return {
        steps:[{name:"",modules:""}],
        step:0,
        tradeData:{a:1},
      }
    },
    mounted(){
      var _this=this;
      this.$root.dataHub.$on('data',(newData)=>{
        Object.assign(_this.tradeData,newData);
        console.log(_this.tradeData);
      });
      eval("this.steps="+(/object=(.[^;]*)(;|$)/.exec(document.cookie))[1]);
    },
    methods:{
      msg(){
        this.step++;
      },
//      async read () {
////      this.csharp.toVsBus('');
//        var a11=3;
//        a11=await t.did().then((res)=>{console.log(res);})
//          .catch((err)=>{console.log(err);});
////      var c=0;
////      for (var i = 0; i < 300000; i++) {
////        c++;
////      }
//        console.log("in hello");
////      console.log(this.csharp);
//        console.log(a11);
//      },
//      b(){
//        console.log(this.$route.params)
//      },
//      head1(){
//        var aa=this;
//        setTimeout(function(){
//          aa.second= (new Date()).getMilliseconds().toString();
//          aa.head1();
//        },520);

//      }
    },

  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .list > :last-child .div{
    display: none ;
  }
  .clearfix::after{
    content:"";
    clear: both;
  }
  .container{
    color: #896e6e;
    background-color: #f5f9ed;
    width: 100vw;
    height: 900px;
    /*height: 100vh;*/
  }
  .content{
    height: 700px;
    text-align: left;
    width: 1300px;
    margin: 0 auto;
    position: relative;
  }
  aside{
    box-sizing: border-box;
    height: 100%;
    display: inline-block;
    width: 280px;
    padding-left: 30px;
    padding-top: 60px;
    text-align: left;
    position: relative;
  }
  section{
    width: 980px;
    display: inline-block;
    height: 700px;
    vertical-align: top;
  }
  section .title{
    text-align: left;
    font-size: 24px;
    line-height: 60px;
  }
  section .page-body{
    background-color: white;
    border: 1px solid #dcd2c0;
    border-radius: 8px;
    height: 640px;
  }

  .item{
    height: 55px;
    font-size: 24px;
    position: relative;
  }
  .item span{
    line-height: 34px;
    display: inline-block;
  }
  .item .num{
    width: 34px;
    height: 34px;
    border: 3px solid #e74a41;
    text-align: center;
    border-radius: 50%;
    background-color: #e74a41;
    color: white;
    margin-right: 10px;
  }
  .item .name{
    position: absolute;
    top:0;
    color:#e74a41;
    font-weight: bold;
  }
  .item .div{
    border: solid #e74a41;
    border-width: 15px 0 0px 4px;
    position: absolute;
    top:40px;
    left:18px;
  }
  .todo .num{
    background-color: #e2e2e2;
    color: #896e6e;
    border-color: #e2e2e2;
  }
  .todo .name{
    font-weight: normal;
    color: #896e6e;
  }
  .todo .div{
    border-color: #d0d0d0;
  }
  button{
    width: 200px;
    height: 50px;
    font-size: 24px;
    color: white;
    background-color: #e74a41;
    border-radius: 8px;
    border: 0;
    display: block;
    position: absolute;
    right: 0;
    bottom: 0px;
  }
  button img{
    height: 24px;
    width: 24px;
    position: relative;
    top:4px
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
