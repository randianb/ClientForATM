<template>
  <div class="authLoading">
    <div class="title">请输入卡、折号和存现金额</div>
    <div class="line"></div>
    <div class="option">
      <div>
        账&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;号：
        <input @blur="check" v-model="No" type="text"/>
      </div>
      <div>
        存现金额：
        <input @blur="check" v-model="Amount" type="text"/>
        <br>（请输入100的整数倍）
      </div>
      <div class="btns">
        <button @click="clearAll">重新输入</button>
        <button class="Rbtn" @click="goNext" :disabled="!done1">下一步</button>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {
        No: '',
        Amount: '',
        done1: false,
        done2:true,
      };
    },
    mounted() {
    },
    methods: {
      check(){
        if (this.No != '' && this.Amount != '')
          this.done1 = true;
        else this.done1 = false;
        console.log(this.done1);
      },
      clearAll(){
        this.No = '';
        this.Amount = '';
      },
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
    padding-top: 80px;
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