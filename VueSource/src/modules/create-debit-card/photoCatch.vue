<template>
  <div class="photoCatch">
    <div class="title">影像采集</div>
    <div class="line"></div>
    <div class="option">
      <canvas width="300px" height="300px" ref="nikon"></canvas>
      <img src="../../../static/trade/picture.png" alt="">
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {};
    },
    mounted() {
      var ctx = this.$refs.nikon.getContext('2d');
      var img = new Image();
      img.src = '../../../static/trade/picture.png';
      img.onload = function () {
        ctx.drawImage(img, 0, 0, 262, 262, 0, 0, 300, 300);
      }
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
    height: 530px;
    /*overflow: hidden;*/
    margin-left: 100px;
    margin-right: 100px;
    line-height: 35px;
  }

  .filed-size select {
    display: inline-block;
    width: 235px;
    height: 38px;
    font-size: 22px;
  }

  canvas {
    height: 300px;
    width: 300px;
    margin: 0 auto;
    display: block;
  }

  .btns {
    width: 700px;
    padding: 0px;
    margin: 0 auto;
  }

  .Rbtn {
    float: right;
  }
</style>