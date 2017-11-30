<template>
  <div>
    <div class="readIDCard" v-if="show">
      <div class="title">请插入您的二代居民身份证，直至读取完成</div>
      <div class="line"></div>
      <div class="option">
        <div :style="{ 'background-image': `url(${imgPath})` }">
        </div>
      </div>
    </div>

    <div class="showIDInfo" v-if="!show">
      <div class='title'>请确认信息是否无误并取走身份证</div>
      <div class='line'></div>
      <div class='detail'>
        <tr>
          <th class="detailFont" justify="left">姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;名：动 林</th>
        </tr>
        <tr>
          <th class="detailFont" justify="left">身份证号：131131131313131313</th>
        </tr>
        <tr>
          <th class="detailFont2" justify="left">性&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;别：男</th>
          <th class="detailFont2" justify="left">民&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;族：汉</th>
        </tr>
        <tr>
          <th class="detailFont" justify="left">出生日期：1989.1.1</th>
        </tr>
        <tr>
          <th class="detailFont" justify="left" span='20'>住&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;址：星海东街32号</th>
        </tr>
      </div>
      <div class="photos clearfix">
        <div class='IDPhoto'>
          <img :src="frontImage" alt="身份证正面照片">
          <div class="description">身份证正面</div>
        </div>
        <div class='IDPhoto'>
          <img :src="backImage" alt="身份证背面照片">
          <div class="description">身份证反面</div>
        </div>
      </div>
      <div class="buttons">
        <button class="buttonL" @click='reload'>重新读取</button>
        <button class="buttonR" @click='goNext'>下一步</button>
      </div>

    </div>
  </div>
</template>

<script>
  import IDCardReader from '../../device/IDCardReader'

  export default {
    components: {},
    data () {
      return {
        show: true,
        imgPath: '../../../static/trade/insertIDCard.gif',
        frontImage: "../../../static/trade/id1.jpg",
        backImage: "../../../static/trade/id2.jpg",
      }
    },
    mounted(){
      this.read();
    },
    methods: {
      reload(){
        this.show = true;
        this.read();
      },
      goNext(){
        this.$root.dataHub.$emit('goNext');
      },
      async read(){
        let a = await IDCardReader.readData(this).then(() => {
            this.show = false;
            this.$root.$data.updateData(a);
          }
        ).catch((err) => {
          let _this = this;
//          this.$modal({
//            time: 30,
//            msg: '读卡器错误',
//            yes_btn: function () {
//              _this.$router.push('/TradeMenu');
//            },
//          }, this);
          console.log(err);
        });
      },
    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .buttons, .photos {
    width: 60%;
    margin: 20px auto 0;
    position: relative;
    display: block;
    position: relative;
  }

  .photos .IDPhoto {
    float: left;
    width: 49.7%;
  }

  .IDPhoto img {
    height: 160px;
    width: 260px;
    border-radius: 8px;
    margin: 0 auto;
    display: block;
  }

  .IDPhoto div {
    text-align: center;
    margin-top: 10px;
  }

  .detail {
    width: 60%;
    margin: 30px auto 0;
    font-size: 24px;
  }

  .detail th {
    font-weight: 100;
    padding: 0 30px 0 0;
  }

  .option {
    height: 560px;
    overflow: hidden;
  }

  .option > div {
    height: 400px;
    width: 340px;
    background-repeat: no-repeat;
    margin: 130px auto 0;

  }

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

  .buttonL {
    color: #e74a41;
    background-color: white;
    border-color: #e74a41;
    font-weight: bold;
  }

  .buttonR {
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
