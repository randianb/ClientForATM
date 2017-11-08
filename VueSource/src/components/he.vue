<template>
    <div class="hello">
        <h2 @click="read">click to call VS method</h2>
        <h2 @click="b">in he show:{{msg}}</h2>
    </div>
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
    methods:{
      async read () {
//      this.csharp.toVsBus('');
        var a11=3;
        var el=document.getElementById('cs');
        el.addEventListener('click',function () {
          console.log('');
        });
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
        document.flag=false;
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
