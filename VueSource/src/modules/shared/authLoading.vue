<template>
  <div class="authLoading">
    <div class="title">授权</div>
    <div class="line"></div>
    <div class="option">
      正在授权，请稍候·····
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
      var _this=this;
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
    height: 530px;
    margin-left: 100px;
    margin-right: 100px;
    margin-top: 200px;
    line-height: 35px;
    text-align: center;
    font-size: 40px;
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