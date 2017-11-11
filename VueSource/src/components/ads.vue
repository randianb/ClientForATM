<template>
  <div class="ads">
    <transition-group name="ad">
      <img v-for="(item,index) in loc" :key="index" @click="touch" v-if="index==mark" :src="item" alt=""/>
    </transition-group>
  </div>
</template>

<script>
  import t from '../device/test'
  import adList from '../../static/list.json'

  export default {
    name: 'ads',
    data () {
      return {
        msg: 'default',
        mark:0,
        loc:adList,
        boo:false,
      }
    },
    created(){
      this.play();
    },
    methods:{
      toggle(){
        if(this.boo)this.boo=false;
        else this.boo=true;
      },
      play(){
        if(this.mark>=this.loc.length)
          this.mark=0;
        let _this=this;
        setTimeout(()=>{
          _this.mark++;
          _this.play();
          },10000);
      },
      touch(){
        this.$router.push('/TradeMenu');
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
    position: relative;
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
