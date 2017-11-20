<template>
  <div class="fingerPrint">
    <div class="title">打印凭条</div>
    <div class="line"></div>
    <div class="option">
      <div class="title1">交易结果提示</div>
      <img :src="imgPath" alt="成功">
      <div class="title2">{{msg}}</div>
      <div class="buttons">
        <button v-if="$root.dataContext.errCode==0" class="buttonL" @click="print">打印</button>
        <button class="buttonR" @click="goNext">确定</button>
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
        imgPath:"../../../static/trade/AuthorizationSuccess.png",
        msg:"恭喜您，存款完成！",
      }
    },
    created(){
//      console.log(this.$root.dataContext);
      if(this.$root.dataContext.errCode!=0){
        this.imgPath="../../../static/trade/AuthorizationFailer.png";
        this.msg="操作失败，请返回"
      }
    },
    methods: {
      print(){
        alert('print');
      },
      goNext(){
        this.$root.dataHub.$emit('goNext');
      }
    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .title2{
    font-size: 34px;
    margin: 40px 0 0;
  }
  .title1{
    overflow: hidden;
    font-size: 40px;
    margin: 70px 0 70px;
  }
  .option{
    height: 560px;
    overflow: hidden;
    text-align: center;
  }
  .option .buttons{
    position: relative;
    width: 70%;
    margin: 40px auto 20px;
    display: block;
    position: relative;
    text-align: left;
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
  .buttonL{
    color: #e74a41;
    background-color: white;
    border-color: #e74a41;
    font-weight: bold;
  }
  .buttonR{
    position: absolute;
    right: 0;
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
