<template>
  <div class="photoCatch">
    <div class="title">影像采集</div>
    <div class="line"></div>
    <div class="option">
      <div><input type="checkbox" id="cphone"/><label for="cphone">手机银行</label></div>
      <div><input type="checkbox" id="phone"/><label for="phone">电话银行</label></div>
      <div><input type="checkbox" id="nopwd"/><label for="nopwd">无磁无密</label></div>
      <div><input type="checkbox" id="d"/><label for="d">无密转账</label></div>
      <div class="btns">
        <button @click="goNext">跳过</button>
        <button class="Rbtn" @click="goNext">下一步</button>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {

      };
    },
    mounted() {
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
    text-align: center;
  }

  .btns {
    margin-top: 40px;
    padding: 0px;
    text-align: left;
  }

  .Rbtn {
    float: right;
  }
</style>