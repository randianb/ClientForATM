<template>
  <div class="InputCustomerInfo">
    <div class="title">填写客户必要信息</div>
    <div class="line"></div>
    <div class="option">
      <div>
        <div class="filed">姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;名:</div>
        <div class="filed">{{IdName}}</div>
      </div>
      <div>
        <div class="filed">身&nbsp;份&nbsp;证&nbsp;号:</div>
        <div class="filed">{{IdNo}}</div>
      </div>
      <div class="filed-size">
        <div class="filed">
          <span style="color:red">*</span>手&nbsp;&nbsp;&nbsp;机&nbsp;&nbsp;号:
        </div>
        <input class="filed-name" v-model="Tel" placeholder="手机号" style="width: 235px"></input>
      </div>
      <div class="filed-size">
        <div class="filed">
          <span style="color:red">*</span>职&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;业:
        </div>
        <select v-model="occu">
          <option selected style="display: none" value="">请选择</option>
          <option v-for="item in occuItems" :label="item.text" :value="item.value"></option>
        </select>
        <span v-if="showOccu" style="color: red">职业为必选项</span>
      </div>
      <div class="filed-size">
        <div class="filed">
          最&nbsp;高&nbsp;学&nbsp;历:
        </div>
        <select v-model="educ">
          <option selected style="display: none" value="">请选择</option>
          <option v-for="item in educItems" :value="item.value">
            {{item.value}}
            {{item.text}}
          </option>
        </select>
      </div>
      <div class="filed-size">
        <div class="filed">
          婚&nbsp;姻&nbsp;状&nbsp;况:
        </div>
        <select v-model="marr">
          <option selected style="display: none" value="">请选择</option>
          <option v-for="item in marrItems" :label="item.text" :value="item.value"></option>
        </select>
      </div>
      <div class="filed-size">
        <div class="filed"> 电&nbsp;子&nbsp;邮&nbsp;箱:</div>
        <input class="filed-name email" v-model="email" placeholder="邮箱帐号" style="width: 235px">
        <span v-if="show" style="color: red">邮箱格式错误,请更改邮箱</span>
      </div>
      <div class="address-div">
        <div class="filed-address"> 居&nbsp;住&nbsp;地&nbsp;址:&nbsp;</div>
        <textarea disabled class="filed-name address" v-model="CtcAdr"></textarea>
      </div>
      <div class="btns">
        <button @click="goBack" style="display:none">上一步</button>
        <button class="Rbtn" @click="goNext">下一步</button>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {
        Tel: '13655555555',
        IdName: '张三',
        IdNo: '1311029128379874823',
        showOccu: false,
        occu: '',
        educ: '',
        email: 'jsaiofjew@126.com',
        CtcAdr: '江苏盐城市五道口',
        show: false,
        occuItems: [{text: '国家机关，党群组织', value: 0}, {text: '专业技术人员', value: 1},
          {text: '办事员或有关人员', value: 2}, {text: '商业从业人员', value: 3}],
        educItems: [{text: '中专', value: 0}, {text: '大专', value: 1}, {text: '本科及以上', value: 2},],
        marrItems: [{text: '已婚', value: 1}, {text: '未婚', value: 0}],
        marr: '',
        value: '选项1',
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

  option :hover {
    background-color: #e0e0e0;
  }

  .option {
    height: 560px;
    overflow: hidden;
    margin-left: 100px;
    margin-top: 30px;
    margin-bottom: 10px;
    line-height: 35px;
  }

  .filed {
    display: inline-block;
    font-size: 20px;
    color: #896e6e;
  }

  .filed-name {
    background: #f2f2f2;
    border: 1px solid #e74a41;
    border-radius: 2px;
    width: 208px;
    height: 38px;
    font-size: 20px;
  }

  .filed-size {
    height: 50px;
  }

  .filed-size select {
    display: inline-block;
    width: 235px;
    height: 38px;
    font-size: 22px;
  }

  .email {
    padding-left: 5px;
  }

  .address-div {
    height: 80px;
  }

  .address {
    background: #f2f2f2;
    border: 1px solid #dcd2c0;
    border-radius: 2px;
    width: 478px;
    height: 50px;
    resize: none;
  }

  .filed-address {
    float: left;
    display: inline-block;
    font-size: 20px;
    color: #896e6e;
  }

  .btns {
    width: 700px;
    padding: 0px;
    margin: 0 auto;
  }

  .Rbtn {
    float: right;
  }
</style>