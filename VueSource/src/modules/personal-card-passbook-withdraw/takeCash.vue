<template>
  <div class="fingerPrint">
    <div class="title">请核对金额并取走您的钞票</div>
    <div class="line"></div>
    <div class="option">
      <div>账户：{{account}}</div>
      <div>金额：{{amount}}</div>
      <div class="btns">
        <button class="Rbtn" @click="goNext">下一步</button>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {
        amount:0,
        account:'111',
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
    padding-top: 100px;
    height: 530px;
    margin-left: 250px;
    margin-right: 250px;
    line-height: 35px;
    text-align: left;
    font-size: 20px;
    position: relative;
  }

  .option > div {
    margin-top: 40px;
  }

  .option .btns {
    padding: 0px;
    text-align: left;
    position: absolute;
    bottom: 200px;
    right: -100px;
  }

  .Rbtn {
    float: right;
  }
</style>