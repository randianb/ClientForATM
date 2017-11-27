<template>
  <div class="container" @mousedown="mousedown" @mouseup="mouseup">
    <header-view></header-view>
    <nav>
      <button class="btn1" @click="upward" v-if="!(tradeMenuSource==tradeMenu)">返回上一级</button>
      <button class="btn2" @click="exit">退出</button>
    </nav>
    <div class="content">
      <transition-group :name="menu">
        <article :key="index" v-for="(i,index) in pageList" v-if="index==page">
          <div @click="menuJump(item)" class="ele" v-for="item in itemList">
            <img :src="item.iconPath" alt="">
            <span>{{item.tradeName}}</span>
          </div>
        </article>
      </transition-group>
    </div>

    <footer-view></footer-view>
  </div>
</template>

<script>
  import TradeMenu from './TradeMenuData.json'
  import Head from './Head'
  import Foot from './Foot'

  export default {
    components: {
      'header-view': Head,
      'footer-view': Foot,
    },
    data() {
      return {
        tradeMenuSource: [{"tradeName": "o"}],
        tradeMenu: [{"tradeName": "o"}],
        xAxis: 0,
        page: 0,
        capacity: 8,
        volume: 0,
        menu: '',
      }
    },
    mounted() {
      console.log('[ATM]:Navigated to /components/TradeMenu.vue');
      this.tradeMenuSource = TradeMenu;
      this.tradeMenu = this.tradeMenuSource;
    },
    methods: {
      exit(){
        this.$router.push('/');
      },
      mousedown(e) {
        this.xAxis = e.screenX;
      },
      mouseup(e) {
        if (20 < this.xAxis - e.screenX) {
          if (this.page < this.volume) {
            this.menu = 'menuleft';
            this.page++;
          }
        }
        if (20 > this.xAxis - e.screenX) {
          if (this.page > 0) {
            this.menu = 'menuright';
            this.page--;
          }
        }
      },
      menuJump(item) {
        document.cookie = 'object=' + JSON.stringify(item.flow) + ';';
        if (item.children && item.children.length > 0) {
          this.tradeMenu = item.children;
        } else {
          this.$router.push({
            name: 'StepNavigator',
            path: '/step-navigator',
            params: {
              code: item.code,
              name: item.tradeName,
            },
          });
        }
        console.log();
      },
      upward() {
        this.tradeMenu = this.tradeMenuSource;
      }
    },
    computed: {
      pageList() {
        let list = [];
        for (let i = 0; i < this.tradeMenu.length / this.capacity; i++) {
          list.push(i);
          this.volume = i;
        }
        return list;
      },
      itemList() {
        let list = [];
        for (let i = this.capacity * this.page;
             i < this.capacity * this.page + this.capacity; i++) {
          if (i < this.tradeMenu.length)
            list.push(this.tradeMenu[i]);
        }
        return list;
      }
    },
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .content {
    width: 1300px;
    margin: 0 auto;
    position: relative;
  }

  .container {
    background-color: #f5f9ed;
    width: 100vw;
    height: 900px;
  }

  button {
    width: 120px;
    height: 50px;
    font-size: 24px;
    color: white;
    background-color: #e74a41;
    border-radius: 8px;
    border: 0;
    display: block;
    margin: 0 50px;
  }

  .btn2 {
    float: right;
  }

  .btn1 {
    width: 180px;
    float: left;
  }

  nav {
    height: 50px;
    width: 100%;
    margin: 20px 0;
  }

  article {
    width: 100%;
    margin: 0 auto;
  }

  .ele {
    box-sizing: border-box;
    /*font-weight: bold;*/
    box-shadow: 0px 0px 13px 5px rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    width: 260px;
    height: 260px;
    background-color: white;
    margin: 0 10px 30px;
    display: inline-block;
    vertical-align: middle;
  }

  .ele img {
    display: inline-block;
    width: 120px;
    height: 120px;
    margin-top: 40px;
    margin-bottom: 10px;
  }

  .ele span {
    display: block;
    font-size: 30px;
    margin-top: 10px;
    height: 78px;
    line-height: 30px;
    vertical-align: top;
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

  .menuright-leave-active, .menuleft-enter-active {
    position: absolute;
    top: 0px;
    transition: all .5s ease;
  }

  .menuright-enter-active, .menuleft-leave-active {
    position: absolute;
    top: 0px;
    transition: all .5s ease;
  }

  .menuright-leave-to, .menuleft-enter {
    position: absolute;
    top: 0px;
    transform: translateX(100vw);
    opacity: 1;
  }

  .menuright-leave, .menuleft-enter-to {
    position: absolute;
    top: 0px;
    /*left:0;*/
  }

  .menuright-enter-to, .menuleft-leave {
    position: absolute;
    top: 0px;
  }

  .menuright-enter, .menuleft-leave-to {
    position: absolute;
    top: 0px;
    transform: translateX(-100vw);
    opacity: 1;
  }
</style>
