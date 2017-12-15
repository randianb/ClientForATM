<template>
  <div id="ChoiceCardType">
    <div class="title">卡产品选择</div>
    <div class="line"></div>
    <div class="cardImg">
      <div class="singleImg">
        <img :src="ICSelected ?'/static/trade/ICSelected.png' : '/static/Trade/ICNotSelected.png'"/>
        <div class="cardName" v-model="ICSelected"
             :style="ICSelected ?  'color:#e74a41' : 'color:#cccccc'">
          紫丁香借记卡
        </div>
      </div>
    </div>
    <div style="text-align: center">
      <div class="read">
        <input style="zoom: 180%;position: relative;top:3px" type="checkbox" id="checkbox" v-model="readChecked">
        <label for="checkbox">我已详细阅读并同意</label>
      </div>
      <div class="detail">
      <span @click="showDetail1">
        <a style="text-decoration:underline;">《开户须知》</a>
      </span>
        <span @click="showDetail2">
        <a style="text-decoration:underline;">《青海省农村信用社个人结算账户管理协议书》</a>
      </span>
        <!--<span @click="showDetail3"><a>《规则3规则3规则3规则3》</a></span>-->
      </div>
    </div>


    <div v-if="Detail1" class="detailRule">
      <div class="detail-wrapper">
        <div>
          <div class="title">青海农信银行借记卡开户须知</div>
        </div>
        <div class="line"></div>
        <div class="content">
          <p class="indent">1.青海省农村信用社坚持“存款自愿、取款自由、存款有息、为储户保密”的原则为客户服务。</p>
          <p class="indent">2.客户自愿在青海省农村信用社开立个人银行账户，并遵循国家法律法规、监管部门规定及青海农村信用社规章制度。</p>
          <p class="indent">3.为客户的存款安全，在开立银行账户时，请按照《个人存款账户实名制规定》，向信用社出示本人的有效身份证明，以实名制开户；代理他人开户的，还需出示代理人的有效身份证明。</p>
          <p class="indent">4.请妥善保管存款凭证（存折/单、卡）和取款密码，存款凭证和密码一旦被他人窃取并支取存款，由客户自行承担可能造成的一切损失。</p>
          <p class="indent">5.办理具有通存通兑功能账户，必须按照相关规定设置个人密码。</p>
          <p class="indent">6.大额现金的存取按照中国人民银行的有关规定办理。</p>
          <p class="indent">
            7.根据中国人民银行《人民币银行结算账户管理办法》的规定，开立借记卡账户视为银行结算账户，具有转账、汇兑、代发工资、代扣款等结算功能，在业务关系存续期间，如果您的身份资料发生变更时，应及时来信用社更新。 </p>
          <p class="indent">8.存折、存单等遗失、被盗、或密码泄露、被改、遗忘应尽快向信用社申请挂失，若存款在挂失前或挂失失效后被他人支取，信用社不承担责任。</p>
          <p class="indent">9.办理定期存款提前支取和存款挂失业务时，须向信用社提供客户本人有效身份证明；代办支取和存款挂失手续的，还须出示代理人的有效身份证明，密码挂失原则不允许代办。</p>
          <p class="indent">10.对一年内未发生收付活动且账户内余额为零的个人银行账户，不需另行通知，信用社有权终止提供服务并予以销户。信用社向客户付息、收取账户管理费用等不属于该条款所述“收付活动”。</p>
          <p class="indent">11.各项收费具体项目及标准详见青海省农村信用社相关收费价格表，信用社有权按价格表收取或自动扣划服务费。如客户未按时支付或账户内余额不足以支付上述费用，信用社有权终止提供服务。</p>
          <p class="indent">12.信用社有权对收费项目及标准进行修改或变动，并按照有关规定，将上述修改或变动以适宜的方式对外公告。公告期满后，客户办理各项业务须按修改后的收费项目及标准支付相关费用。</p>
          <p class="indent">13.因通讯异常、不可抗力因素或客户本人原因造成的损失，信用社不承担责任。</p>
        </div>
        <div class="footer clearfix">
          <button class="Rbtn" @click="confirm1" :fill="true" size="small">确定</button>
        </div>
      </div>
    </div>
    <div v-if="Detail2" class="detailRule">
      <div class="detail-wrapper">
        <div>
          <div class="title">青海省农村信用社个人结算账户管理协议书</div>
        </div>
        <div class="line"></div>
        <div class="content">
          <p>甲方：青海省农村信用社</p>
          <p>乙方：开立（确认）个人结算账户申请人</p>
          <p class="indent">第一条 根据中国人民银行《人民币银行结算账户管理办法》的规定，甲、乙双方就个人结算账户有关事项达成如下协议，共同信守。</p>
          <p class="indent">第二条 甲方承担以下责任：</p>
          <p class="indent">1、依法保障乙方的资金安全，并依法为乙方的银行结算账户信息保密，除国家法律另有规定外，甲方有权拒绝任何单位或个人查询、冻结、扣划。</p>
          <p class="indent">2、及时准确地办理乙方的资金收付业务，为乙方提供账务核对、挂失、临时挂失和更改密码等服务。</p>
          <p class="indent">
            3、在本协议履行过程中，乙方向甲方提供的甲方不能从公共渠道取得的有关乙方信息，均构成乙方保密信息，甲方除非为履行本协议项下规定的义务之目的，不得向任何第三方披露或许可使用该保密信息，甲方根据中国法律或其他适用法律法规规定有义务进行披露的情形及双方在其他协议中另有规定的除外。</p>
          <p class="indent">第三条
            乙方应保证开户资料的真实、完整、合法、不得凭伪造、变造证明文件欺骗甲方开立银行结算账户。乙方以临时身份证开立个人银行结算账户的，应在临时身份证到期前，携正式身份证到甲方营业网点，修改账户资料中的证件内容。如有个人资料变更，乙方应及时通知甲方办理变更手续。由于乙方未能及时向甲方提供正确资料而造成的损失，由乙方自行承担。</p>
          <p class="indent">第四条
            乙方开立个人结算账户时，应提供有效身份证件。开立借记卡和存折账户应预留密码。乙方收到借记卡时应当面确认借记卡（及密码信封）完整无损，及时更改密码并妥善保管。凡甲方根据借记卡（或存折）和密码为乙方办理业务，因密码泄露而造成的损失，由乙方承担。</p>
          <p class="indent">第五条 乙方开立个人支票户，应本人办理并预留签章，甲方根据签章为乙方办理业务。</p>
          <p class="indent">乙方遗失或变更预留个人签章的，本人应出具经其本人签名确认的书面申请，在其开户网点办理。</p>
          <p class="indent">第六条
            乙方应定期主动与甲方核对账务。乙方发生账务后应及时通过甲方提供的柜台、电话银行、网上银行、自助设备等设施核对账务，如有异议及时向甲方提出。如果乙方从交易发起3个月内（以自然日计算）未对账户信息向甲方提出疑问，则视为对交易记录无异议。</p>
          <p class="indent">第七条 乙方应了解并同意以下做法：</p>
          <p class="indent">借记卡开卡时，借记卡及其主账户将自动确认为个人结算账户，销户时视同个人结算账户销户。</p>
          <p class="indent">第八条 正在办理代发工资、消费信贷扣款、代缴费等结算账户业务的个人结算账户不得销户。</p>
          <p class="indent">第九条 乙方应承担因未遵守《人民币银行结算账户管理方法》及本协议而造成的损失。</p>
          <p class="indent">第十条 以上内容如发生变更，甲方以公告形式通知乙方。</p>
          <p class="indent">第十一条 本《协议书》由双方签章生效。本《协议书》一式两份，甲乙双方各持一封。</p>
        </div>
        <div class="footer clearfix">
          <button class="Rbtn" @click="confirm2" :fill="true" size="small">确定</button>
        </div>
      </div>
    </div>
    <div class="btns">
      <button @click="goBack" style="display:none">上一步</button>
      <button @click="goNext" class="Rbtn" :disabled="!readChecked">确定</button>
    </div>
  </div>
</template>

<script>
  export default {
    name: 'page',
    data() {
      return {
        checked: true,
        firstSelected: true,
        secondSelected: false,
        ICSelected: true,
        selectCardNum: '',
        icCardNum: '',
        cityCardNum: '',
        readChecked: '',
        Detail1: false,
        Detail2: false,
        Detail3: false
      };
    },
    mounted() {
    },
    methods: {
      confirm1(){
        this.Detail1 = false;
      },
      confirm2(){
        this.Detail2 = false;
      },
      showDetail1(){
        this.Detail1 = true;
      },
      showDetail2(){
        this.Detail2 = true;
      },
      goNext(){
        this.$root.dataHub.$emit('goNext');
      },
      goBack(){
        this.$root.dataHub.$emit('goBack');
      }
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

  .stepHintRow {
    border-bottom: 1px solid #dcd2c0;
  }

  .singleImg {
    display: inline-block;
  }

  .read {
    margin-top: 4px;
    display: inline-block;
  }

  .read label {
    color: #000;
  }

  .detail {
    margin-left: 15px;
    margin-top: 10px;
    display: inline-block;
  }

  .detail span {
    color: #000;
    margin-left: 10px;
    margin-top: 8px;
    white-space: nowrap;
  }

  .stepHint {
    font-size: 30px;
    color: #896e6e;
    margin-top: 20px;
    margin-bottom: 10px;
    line-height: 42px;
    font-weight: bold;
  }

  .selected {
    font-size: 30px;
    color: #896e6e;
    width: 50%;
    float: left;
    text-align: center;
    line-height: 60px;
  }

  .notSelected {
    background: #f5f5f5;
    font-size: 30px;
    color: #999999;
    width: 50%;
    text-align: center;
    float: left;
    line-height: 60px;
  }

  .cardSelectedFirst {
    width: 720px;
    margin: 0 auto;
  }

  .cardImg {
    margin-top: 100px;
    margin-bottom: 20px;
    text-align: center;
  }

  .cardName {
    font-size: 20px;
    color: #cccccc;
  }

  .last_steppicture {
    width: 200px;
    height: 60px;
    border-radius: 8px;
    margin-top: 100px;
    margin-bottom: 39px;
    display: inline-block;
  }

  .detailRule {
    color: #000;
    z-index: 100;
    position: fixed;
    z-index: 100;
    top: 0px;
    left: 0px;
    width: 100%;
    height: 100%;
    overflow: auto;
    background: rgba(7, 17, 27, 0.4);
  }

  .detail-wrapper {
    background-color: #fff;
    width: 1000px;
    margin: 20px auto;
    padding: 20px 0;
    border-radius: 10px;
  }

  .detail-wrapper h3 {
    color: #000;
    text-align: center;
    margin-top: 40px;
  }

  .content {
    font-size: 20px;
    color: #896e6e;
    margin: 30px 70px;
    width: 860px;
    height: 380px;
    overflow-y: scroll;
    /*padding-right: 20px;*/
    /*padding-left: 20px;*/
    white-space: wrap;
  }

  .Rule-Page {
    background: #ffffff;
    border-radius: 8px;
    width: 900px;
    height: 560px;
    z-index: 100;
  }

  .footer {
    margin-top: 20px;
  }

  .indent {
    text-indent: 40px;
  }

  .detail span a {
    color: #0000FF;
    cursor: pointer;
  }

  .btns {
    width: 700px;
    padding: 0px;
    margin: 0 auto;
  }

  .Rbtn {
    margin-top: 30px;
    float: right;
  }
</style>
