<template>
  <div class="fingerPrint">
    <div class="title">请放入钞票</div>
    <div class="line"></div>
    <div class="option">
      <div>
        <img :src="imgPath" alt="">
        <button class="buttons" @click="goNext">放钞完成</button>
      </div>
    </div>
  </div>
</template>

<script>
  //  import t from '../device/test'

  export default {
    components: {
    },
    data () {
      return {
        imgPath:"../../../static/trade/cash.png",
      }
    },
    props:['dataContext'],
    created(){
    },
    methods: {
      goNext(){
        this.$root.dataHub.$emit('data',{cash:0,errCode:1});
        this.$root.dataHub.$emit('goNext');
      }
    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .option{
    height: 560px;
    overflow: hidden;
  }
  .option >div{
    width: 640px;
    margin: 30px auto 0;
    position: relative;
  }
  .option div img{
    width: 100%;
    display: block;
  }
  .title{
    font-size: 30px;
    height: 40px;
    padding-top: 40px;
    text-align: center;
  }
  .line{
    height: 0px;
    border-top:1px solid #dcd2c0;
    width: 90%;
    margin: 30px auto 0;
  }
  button{
    position: absolute;
    right: 0;
    margin:20px 20px 0;
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
