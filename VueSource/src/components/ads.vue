<template>
  <div class="ads">
    <transition-group name="ad">
      <img id="f" v-for="(item,index) in loc" @click="touch" :key="index"  v-if="index==mark" :src="item" alt=""/>
    </transition-group>
  </div>
</template>

<script>
  import t from '../device/test'
  export default {
    name: 'hello',
    data () {
      return {
        msg: 'default',
        mark:0,
        loc:["/../static/welcome.png","/../static/passbook.gif"],
        boo:false,
      }
    },
    created(){
      this.play(0);
    },
    methods:{
      toggle(){
        if(this.boo)this.boo=false;
        else this.boo=true;
      },
      play(index){
        if(index>=this.loc.length)
          index=0;
//        this.item=this.loc[index];
//        console.log(index);
        this.mark=index;
        let _this=this;
        setTimeout(()=>{
          index++;
          _this.play(index);
          },3000);
      },
      touch(){
        this.$router.push('/he');
      },
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
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .ads{
    background-color: white;
    overflow: hidden;
    height: 100vh;
    width: 100vw;
    position: relative;
  }
  img{
    width: 100%;
    height:100%;
  }
  .ad-enter-active {
    position: absolute;
    top:0;
    transition: all .5s ease;
  }
  .ad-leave-active {
    position: absolute;
    top:0;
    transition: all .5s ease;
  }
  .ad-enter {
    position: absolute;
    top:0;
    transform: translateX(-100vw);
    opacity: 1;
  }
  .ad-enter-to {
    position: absolute;
    top:0;
    left:0;
  }
  .ad-leave{
    position: absolute;
    top:0;
  }
  .ad-leave-to {
    position: absolute;
    top:0;
    transform: translateX(100vw);
    opacity: 1;
  }
</style>
