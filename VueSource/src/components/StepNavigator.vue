<template>
  <div class="container">
    <header-view></header-view>

    <div class="content">
      <aside>
        d
        <button>返回</button>
      </aside>
      <section>
        <div class="title">{{this.$route.params.name}}</div>
        <div class="body">
          
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
  section{
    padding-left: 290px;
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
  aside{
    float: left;
    width: 240px;
    padding-left: 30px;
    padding-top: 60px;
    background-color: aquamarine;
    border: 1px solid;
    text-align: left;
  }
  .container{
    background-color: #f5f9ed;
    width: 100vw;
    height: 900px;
  }
  .content{
    width: 1300px;
    margin: 0 auto;
  }
  button{
    width: 180px;
    height: 50px;
    font-size: 24px;
    color: white;
    background-color: #e74a41;
    border-radius: 8px;
    border: 0;
    display: block;
    margin:0 50px;
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
