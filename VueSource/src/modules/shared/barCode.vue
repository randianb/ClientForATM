<template>
  <div class="fingerPrint">
    <div class="title">请放入钞票</div>
    <div class="line"></div>
    <div class="option">
      <div>
        <img :src="imgPath" alt="">
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {
        imgPath:"../../../static/trade/QRImageScan.gif",
      };
    },
    mounted() {
      let _this=this;
      setTimeout(function () {
        _this.goNext();
      },2000);
    },
    methods: {
      goNext(){
        this.$root.dataHub.$emit('goNext');
      },
      goBack(){
        this.$root.dataHub.$emit('goBack');
      }
    }
  }

</script>

<style scoped>
  .title {
    font-size: 30px;
    height: 40px;
    padding-top: 40px;
    text-align: center;
  }

  .line {
    height: 0px;
    border-top: 1px solid #dcd2c0;
    width: 90%;
    margin: 30px auto 0;
  }

  .option {
    padding-top: 20px;
    height: 530px;
    margin-left: 100px;
    margin-right: 100px;
    line-height: 35px;
    text-align: center;
    font-size: 20px;
  }

  .option > div {
    margin-top: 40px;
  }

  .option .btns {
    margin-top: 120px;
    padding: 0px;
    text-align: left;
  }

  .Rbtn {
    float: right;
  }
</style>