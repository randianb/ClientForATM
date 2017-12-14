<template>
  <div id="SetPassWord">
    <div class="title">设置密码</div>
    <div class="line"></div>
    <div class="inputFirst">
      <div class="inputFirstHint" span="14" offset="6" justify="left">请输入银行卡密码（6位数字）</div>
    </div>
    <div class="passWordFirst">
      <div span="14" offset="6" justify="left">
        <input type="password"  ref="pswdOne"/>
      </div>
    </div>
    <div class="inputSecond">
      <div class="inputFirstHint" span="10" offset="6" justify="left">
        请再次输入银行卡密码（6位数字）
      </div>
    </div>
    <div class="passWordSecond">
      <div span="14" offset="6" justify="left">
        <input type="password" ref="pswdTwo"/>
      </div>
    </div>
    <div class="errorHint">
      <div v-show="different" span="14" offset="6" justify="left"><span>
      <img src="/static/Trade/warn.png" alt=""></span>
        <span class="errHint">两次输入的密码不一致，请重新输入！</span></div>
    </div>
    <div>
      <div span="12">
        <button @click="clearAll">重新输入</button>
      </div>
      <div span="12">
        <button :fill="true" @click="goNext" :disable="!different">下一步</button>
      </div>
    </div>
  </div>
</template>

<script>
  let getPinInput = {
    'TerminateKeys': 3072,
    'TerminateFDKs': 0,
    'ActiveKeys': 16383,
    'ActiveFDKs': 0,
    'Echo': 0,
    'AutoEnd': true,
    'MaxLen': 6,
    'MinLen': 6
  };

  export default {
    name: 'page',
    data() {
      return {
        different: false,
        getPinInputPara: getPinInput,
        pinBlock: '',
        pinBlockAgain: '',
        keyCount: 0,
        keyCountAgain: 0
      };
    },
    methods: {},
    created() {
    }
  };
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

  #set-pass-word {
    width: 100%;
    height: 100%;
    background: white;
  }

  .stepHintRow {
    border-bottom: 1px solid #dcd2c0;
    width: 900px;
    margin: 0 auto;
  }

  .stepHint {
    font-size: 30px;
    color: #896e6e;
    margin-top: 20px;
    margin-bottom: 11px;
  }

  .inputFirstHint {
    font-size: 24px;
    color: #896e6e;
  }

  .errHint {
    font-size: 20px;
    color: #ff6633;
  }

  .inputFirst {
    margin-top: 57px;
    margin-bottom: 10px;
  }

  .inputSecond {
    margin-top: 37px;
    margin-bottom: 10px;
  }

  .errorHint {
    margin-top: 29px;
    margin-bottom: 79px;
    height: 35px;
  }
</style>
