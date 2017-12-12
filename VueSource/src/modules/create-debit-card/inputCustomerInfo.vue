<template>
  <div class="InputCustomerInfo">
    <tr>
      <td>
        <h2>填写客户必要信息</h2>
      </td>
    </tr>
    <tr>
      <td>
        <div class="custom-info">
          <div>
            <div class="filed">姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;名:</div>
            <div class="filed">{{IdName}}</div>
          </div>
          <div>
            <div class="filed">身&nbsp;份&nbsp;证&nbsp;号:</div>
            <div class="filed">{{IdNo}}</div>
          </div>
        </div>
      </td>
    </tr>
    <tr>
      <td>
        <div class="custom-info-2">
          <div class="filed-size">
            <div class="filed">
              <span style="color:red">*</span>手&nbsp;&nbsp;机&nbsp;&nbsp;号:
            </div>
            <input class="filed-name" v-model="Tel" placeholder="手机号" style="width: 235px" disabled="true"></input>
          </div>
          <div class="filed-size">
            <div class="filed">
              <span style="color:red">*</span>职&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;业:
            </div>
            <select style="display:inline-block" v-model="occu" :maxLines="maxLines">
              <option v-for="item in occuItems" :key="item" :label="item.Text" :value="item.Value"></option>
            </select>
            <span v-if="showOccu" style="color: red">职业为必选项</span>
          </div>
          <div class="filed-size">

            <div class="filed">
              最&nbsp;高&nbsp;学&nbsp;历:
            </div>
            <select style="display:inline-block" v-model="educ" :maxLines="maxLines">
              <option v-for="item in educItems" :key="item" :label="item.Text" :value="item.Value"></option>
            </select>
          </div>
          <div class="filed-size">
            <div class="filed">
              婚&nbsp;姻&nbsp;状&nbsp;况:
            </div>
            <select style="display:inline-block" v-model="marr" :maxLines="maxLines">
              <option v-for="item in marrItems" :key="item" :label="item.Text" :value="item.Value"></option>
            </select>
          </div>
          <div class="filed-size">
            <div class="filed"> 电&nbsp;子&nbsp;邮&nbsp;箱:</div>
            <input class="filed-name email" v-model="email" placeholder="邮箱帐号" style="width: 235px"
                   v-keyboard="'normal'"></input>
            <span v-if="show" style="color: red">邮箱格式错误,请更改邮箱</span>
          </div>
          <div class="address-div">
            <div class="filed-address"> 居&nbsp;住&nbsp;地&nbsp;址:&nbsp;</div>
            <textarea disabled class="filed-name address" v-model="CtcAdr" v-keyboard="'text'"></textarea>
          </div>
        </div>
      </td>
    </tr>
    <tr>
      <td>
        <div class="next_div">
          <button @click="goBack" style="display:none">上一步</button>
          <button class="next_button" :fill="true" @click="goNext">下一步</button>
        </div>
      </td>
    </tr>
  </div>
</template>


<script>
  let metadata = {
    name: 'InputCustomerInfo.vue',
    description: '填写客户信息',
    outlets: {
      确定: 'OK',
      取消: 'Cancel'
    }
  }

  export default {
    data() {
      return {
        Tel: '',
        IdName: '',
        IdNo: '',
        showOccu: false,
        occu: '',
        educ: '',
        email: '',
        CtcAdr: '',
        maxLines: 5,
        show: false,
        occuItems: '',
        educItems: '',
        marrItems: '',
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
  .InputCustomerInfo {
    height: 640px;
    position: relative;
  }

  .InputCustomerInfo h2 {
    font-size: 30px;
    color: #896e6e;
    width: 900px;
    height: 72px;
    text-align: center;
    margin: 0 auto;
    line-height: 72px;
    border-bottom: 1px solid #dcd2c0;
  }

  .custom-info {
    width: 800px;
    margin-left: 100px;
    margin-top: 30px;
    line-height: 35px;
  }

  .custom-info-2 {
    width: 800px;
    margin-left: 100px;
    margin-top: 6px;

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

  .next_div {
    width: 520px;
    padding: 0px;
    margin-top: 30px;
  }

  .next_button {
    float: right;
  }
</style>