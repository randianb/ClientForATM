<template>
  <div class="fingerPrint">
    <div class="title">请柜员输入指纹 完成授权</div>
    <div class="line"></div>
    <div class="option">
      <div>
        <img :src="imgPath" alt="">
      </div>
    </div>
  </div>
</template>

<script>
  import fingerPrint from '../../device/fingerPrint'

  export default {
    data () {
      return {
        imgPath: "../../../static/trade/fingerPrints.png",
      }
    },
    props: [],
    async mounted(){
      let a = await fingerPrint.readData(this).then(() => {
          this.goNext();
        }
      ).catch(() => {
        console.log('指纹： error');
      });
    },
    methods: {
      goNext(){
        this.$root.dataHub.$emit('goNext');
      }
    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .option {
    height: 560px;
    overflow: hidden;
  }

  .option > div {
    width: 340px;
    margin: 80px auto 0;
  }

  .option div img {
    width: 100%;
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
