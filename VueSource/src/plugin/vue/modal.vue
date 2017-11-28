<template>
  <div v-if="show" class="modal">
    <div class="box">
      <span class="timer" v-if="showtimer">{{timer}}</span>
      <img :src="imgPath" alt="">
      <div class="msg">{{msg}}</div>
      <button :class="{LButton:DButton}" @click="yes">确定</button>
      <button v-if="DButton" @click="no">取消</button>
    </div>
  </div>
</template>

<script>
  import Timer from '../../plugin/timer'

  export default {
    name: 'modal',
    data() {
      let _this;
      _this=this;
      return {
        ff:'d',
        img: '',
        imgPath: '',
        show: true,
        msg: '',
        DButton: true,
        yes_fun: undefined,
        no_fun: undefined,
        time: 0,
        showtimer: false,
        startup: function () {
          (function () {
            if (_this.img == 'yes')
              _this.imgPath = "../../../static/trade/checkPass.png";
            if (_this.img == 'no')
              _this.imgPath = "../../../static/trade/checkFail.png";
            if (_this.img == 'info')
              _this.imgPath = "../../../static/trade/disChecked.png";
          })();
          if (_this.time > 0) {
            _this.showtimer = true;
            Timer.Ini(_this.time ,function () {
              _this.yes();
            },_this);
          }
          else this.showtimer = false;
        }
      }
    },
    methods: {
      yes(){
        this.show = false;
        this.yes_fun();
//        this.$destroy();
      },
      no(){
        this.show = false;
        this.no_fun();
//        this.$destroy();
      },
    },
    computed: {
      timer(){
        return this.time + 's';
      }
    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .hide {
    display: none;
  }

  .timer {
    position: absolute;
    top: 10px;
    right: 60px;
    display: inline-block;
    font-size: 34px;
    color: #E74A41;
  }

  .modal {
    width: 100vw;
    height: 100vh;
    background-color: rgba(0, 0, 0, .3);
    position: absolute;
    top: 0;
    left: 0;
  }

  .box {
    padding: 20px 20px 0 20px;
    text-align: center;
    font-size: 26px;
    border-radius: 6px;
    background-color: white;
    display: inline-block;
    position: absolute;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;
    margin: auto;
    width: 460px;
    height: 200px;
    /*box-sizing: border-box;*/
  }

  img {
    display: block;
    width: 40px;
    height: 40px;
    margin: 10px auto;
    border-style: none;
  }

  .msg {
    text-align: center;
    padding-top: 10px;
    margin: 0 auto;
    max-width: 400px;
  }

  button {
    line-height: 30px;
    height: 36px;
    width: 110px;
    font-size: 22px;
    position: absolute;
    bottom: 30px;
    margin: 0;
    right: 70px;
  }

  .LButton {
    background-color: white;
    color: #E74A41;
    left: 70px;
  }
</style>
