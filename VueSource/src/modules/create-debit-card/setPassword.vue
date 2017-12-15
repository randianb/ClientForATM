<template>
  <div id="SetPassWord">
    <div class="title">设置密码</div>
    <div class="line"></div>
    <div class="option">
      <div class="inputFirst">
        <div class="inputFirstHint">请输入银行卡密码（6位数字）</div>
      </div>
      <div class="passWordFirst">
        <input @keyup="get" readonly="readonly"
               type="password" ref="pwdOne"/>
        <div>
          <div :class="{dot:fpwd[0]}"></div>
          <div :class="{dot:fpwd[1]}"></div>
          <div :class="{dot:fpwd[2]}"></div>
          <div :class="{dot:fpwd[3]}"></div>
          <div :class="{dot:fpwd[4]}"></div>
          <div :class="{dot:fpwd[5]}"></div>
        </div>
      </div>
      <div class="inputSecond">
        <div class="inputFirstHint">
          请再次输入银行卡密码（6位数字）
        </div>
      </div>
      <div class="passWordSecond">
        <input @keyup="get2" readonly="readonly" type="password" ref="pwdTwo"/>
        <div>
          <div :class="{dot:spwd[0]}"></div>
          <div :class="{dot:spwd[1]}"></div>
          <div :class="{dot:spwd[2]}"></div>
          <div :class="{dot:spwd[3]}"></div>
          <div :class="{dot:spwd[4]}"></div>
          <div :class="{dot:spwd[5]}"></div>
        </div>
      </div>
      <div class="errorHint">
        <div v-show="different">
          <span>
            <img src="/static/trade/warn.png">
          </span>
          <span class="errHint">
            两次输入的密码不一致，请重新输入！
          </span>
        </div>
      </div>
      <div class="btns">
        <button @click="clearAll">重新输入</button>
        <button class="Rbtn" @click="goNext" :disable="!different">下一步</button>
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
        keyCountAgain: 0,
        fpwd: [],
        spwd: [],
      };
    },
    mounted(){
      this.$refs.pwdOne.focus();
    },
    methods: {
      get(e){
        if (e.keyCode >= 48 && e.keyCode < 58) {
          this.fpwd.push(String.fromCharCode(e.keyCode));
        }
        if (this.fpwd.length >= 6) {
          this.fpwd = this.fpwd.slice(0, 6);
          this.$refs.pwdTwo.focus();
        }
      },
      get2(e){
        if (e.keyCode >= 48 && e.keyCode < 58) {
          this.spwd.push(String.fromCharCode(e.keyCode));
        }
        if (this.spwd.length >= 6) {
          this.spwd = this.spwd.slice(0, 6);
          if (JSON.stringify(this.fpwd) != JSON.stringify(this.spwd)) {
            this.different = true;
          }
        }
      },
      clearAll(){
        this.fpwd = [];
        this.spwd = [];
        this.different = false;
        this.$refs.pwdOne.focus();
      },
      goNext(){

        this.$root.dataHub.$emit('goNext');
      },
      goBack(){
        this.$root.dataHub.$emit('goBack');
      }
    },
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

  .btns {
    text-align: left;
    width: 700px;
    padding: 0px;
    margin: 0 auto;
  }

  .Rbtn {
    float: right;
  }

  input {
    outline-style: none;
    position: relative;
    background-color: transparent;
    line-height: 30px;
    border: 2px solid #e74a41;
    width: 214px;
    border-radius: 10px;
    height: 30px;
    letter-spacing: 20px;
    display: inline-block;
    z-index: 3;
  }

  .dot::after {
    content: '';
    display: block;
    position: relative;
    background-color: black;
    border-radius: 50%;
    width: 4px;
    height: 4px;
    left: 14px;
    top: 14px;
  }

  .passWordFirst {
    position: relative;
    z-index: 1;
  }

  .passWordFirst > div {
    position: absolute;
    top: 3px;
    left: 382px;
    z-index: 2;
  }

  .passWordFirst div div {
    display: block;
    height: 32px;
    border-right: 2px solid #e74a41;
    float: left;
    width: 34px;
  }

  .passWordFirst div :last-child {
    border-right: 0;
  }

  .passWordSecond {
    position: relative;
    z-index: 1;
  }

  .passWordSecond > div {
    position: absolute;
    top: 3px;
    left: 382px;
    z-index: 2;
  }

  .passWordSecond div div {
    display: block;
    height: 31px;
    border-right: 2px solid #e74a41;
    float: left;
    width: 34px;
  }

  .passWordSecond div :last-child {
    border-right: 0;
  }

  .option {
    height: 560px;
    overflow: hidden;
    margin-bottom: 10px;
    line-height: 35px;
    text-align: center;
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
