<template>
  <div>
    <div class="readIDCard" v-if="show">
      <div class="title">请插入您的二代居民身份证，直至读取完成</div>
      <div class="line"></div>
      <div class="option">
        <div class="insertIDcard" :style="{ 'background-image': `url(${bgImg})` }">
        </div>
      </div>
    </div>

    <div class="showIDInfo" v-else-if="!show">
      <div class='title'>请确认信息是否无误并取走身份证</div>
      <div class='line'></div>
      <aui-row>
        <aui-col justify="left">
          <div class='detail' style='margin-left: 20%;'>
            <aui-row>
              <aui-col class="detailFont" justify="left">姓&nbsp;&nbsp;&nbsp;&nbsp;名：{{this.session.Customer.Name}}</aui-col>
            </aui-row>
            <aui-row>
              <aui-col class="detailFont" justify="left">身份证号：{{this.session.Customer.CtfNum}}</aui-col>
            </aui-row>
            <aui-row>
              <aui-col class="detailFont2" justify="left">性&nbsp;&nbsp;&nbsp;&nbsp;别：{{dm.Gnd}}</aui-col>
              <aui-col class="detailFont2" justify="left">民族：{{dm.EthcGrp}}</aui-col>
            </aui-row>
            <aui-row>
              <aui-col class="detailFont" justify="left">出生日期：{{dm.IdBirthday}}</aui-col>
            </aui-row>
            <aui-row>
              <aui-col class="detailFont" justify="left" span='20'>住&nbsp;&nbsp;&nbsp;&nbsp;址：{{this.session.Customer.IdAddress}}</aui-col>
            </aui-row>
          </div>
        </aui-col>
      </aui-row>
      <div style="margin-top: 20px;">
        <div class='IDPhoto' style="margin-left: 20%;">
          <img :src="dm.IDCardFrontImage" alt="身份证正面照片" height='160px' width='260px' style='border-radius: 8px;'>
        </div>
        <div class='IDPhoto' style="margin-left: 5%;">
          <img :src="dm.IDCardBackImage" alt="身份证背面照片" height='160px' width='260px' style='border-radius: 8px;'>
        </div>
      </div>
      <aui-row>
        <aui-col class="detailFont2" style='margin-left: 23%;'>身份证正面</aui-col>
        <aui-col class="detailFont2" style='margin-left: 14%;'>身份证反面</aui-col>
      </aui-row>
      <div style='position: absolute; bottom:40px; right: 20%;'>
        <aui-button @click='onNavigated' style="margin-right: 200px">重新读取</aui-button>
        <aui-button :fill="true" @click='goNext'>下一步</aui-button>
      </div>

    </div>
  </div>
</template>

<script>
  //  import t from '../device/test'

  export default {
    components: {
    },
    data () {
      return {
        show:true,
      }
    },
    props:['dataContext'],
    created(){
    },
    methods: {
      b(){
        let a='131';
        this.$root.dataHub.$emit('data',{idcode:a});
      },

    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
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
