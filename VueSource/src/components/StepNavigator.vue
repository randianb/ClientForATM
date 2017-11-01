<template>
  <div class="container">
    <header-view></header-view>

    <div class="content">
      <aside>
        <div class="list">
          <div class="item">
            <span class="num">1</span>
            <span class="div"></span>
            <span class="name">刷身份证</span>
          </div>
          <div class="item">
            <span class="num">1</span>
            <span class="div"></span>
            <span class="name">刷身份证</span>
          </div>
        </div>
        <button><img src="../../static/trade/home.png"> &nbsp;返回</button>
      </aside>
      <section>
        <div class="title">{{this.$route.params.name}}</div>
        <div class="body">
joifwejio
        </div>
      </section>
    </div>

    <footer-view></footer-view>
  </div>
</template>

<script>
  import t from '../device/test'
  import Head from './Head'
  import Foot from './Foot'

  export default {
    components:{
      'header-view':Head,
      'footer-view':Foot,
    },
    data () {
      return {
//        title:this.$router.pa
        msg: 'default',
        second:'',
        flag:true
      }
    },
    created(){

    },
    methods:{
      async read () {
//      this.csharp.toVsBus('');
        var a11=3;
        a11=await t.did().then((res)=>{console.log(res);})
          .catch((err)=>{console.log(err);});
//      var c=0;
//      for (var i = 0; i < 300000; i++) {
//        c++;
//      }
        console.log("in hello");
//      console.log(this.csharp);
        console.log(a11);
      },
      b(){
        console.log(this.$route.params)
      },
      head1(){
        var aa=this;
        setTimeout(function(){
          aa.second= (new Date()).getMilliseconds().toString();
          aa.head1();
        },520);

      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .list > :last-child .div{
    display: none ;
    /*border: 3px solid black !important;*/
  }
  .clearfix::after{
    content:"";
    clear: both;
  }
  aside{
    height: 100%;
    display: inline-block;
    /*min-height: 400px;*/
    width: 220px;
    padding-left: 30px;
    padding-top: 60px;
    text-align: left;
    position: relative;
  }
  section{
    width: 980px;
    display: inline-block;
    /*position: absolute;*/
    /*top:0;*/
    /*padding-left: 280px;*/
    height: 700px;
    vertical-align: top;
  }
  section .title{
    text-align: left;
    font-size: 24px;
    line-height: 60px;
  }
  section .body{
    background-color: white;
    border: 2px solid #dcd2c0;
    border-radius: 8px;

  }

  .item{
    height: 55px;
    font-size: 24px;
    position: relative;
  }
  .item span{
    line-height: 40px;
    display: inline-block;
  }
  .item .num{
    width: 40px;
    height: 40px;
    border: none ;
    text-align: center;
    border-radius: 50%;
    background-color: #e74a41;
    color: white;
    margin-right: 10px;
  }
  .item .name{
  }
  .item .div{
    border: solid #e74a41;
    border-width: 15px 0 0px 4px;
    position: absolute;
    top:40px;
    left:18px;
  }
  .container{
    color: #896e6e;
    background-color: #f5f9ed;
    width: 100vw;
    height: 900px;
  }
  .content{
    /*height: 100%;*/
    text-align: left;
    width: 1300px;
    margin: 0 auto;
    position: relative;
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
    bottom: 10px;
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
