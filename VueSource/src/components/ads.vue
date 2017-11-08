<template>
  <div class="ads">
    <img src="../../static/welcome.png" alt=""></div>
</template>

<script>
  import t from '../device/test'
  export default {
    name: 'hello',
    data () {
      return {
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
        this.$router.push('/he');
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
  .ads{
    background-color: red;
    height: 100vh;
    width: 100vw;
  }
  img{
    width: 100%;
    height:100%;
  }
</style>
