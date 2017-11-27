<template>
  <div class="ads">
    <transition-group name="ad">
      <img class="ad-leave" v-for="(item,index) in loc" :key="index" @click="touch" v-if="index==mark" :src="item" alt=""/>
    </transition-group>
  </div>
</template>

<script>
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
    mounted(){
      console.log('[ATM]:Navigated to /components/Ads.vue');
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
          },6000);
      },
      touch(){
        this.$router.push('/TradeMenu');
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
    /*height: 400px;*/
    /*width: 800px;*/
    /*margin-left: 300px;*/
  }
  img{
    /*height: 400px;*/
    /*width: 800px;*/
    margin: 0;
    display: block;
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
    /*transform: translateX(-800px);*/
    transform: translateX(-100vw);
    opacity: 1;
  }
  .ad-enter-to {
    position: absolute;
    top:0;
  }
  .ad-leave{
    position: absolute;
    top:0;
  }
  .ad-leave-to {
    position: absolute;
    top:0;
    /*transform: translateX(800px);*/
    transform: translateX(100vw);
    opacity: 1;
  }
</style>
