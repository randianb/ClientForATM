<template>
  <div class="body">
    <transition mode="out-in" name="page">
      <component :is="compName"></component>
    </transition>
  </div>
</template>

<script>
  //  组件错误请同时检查tradeMenuData
  import readIDCard from './readIDCard'
  import fingerPrint from './fingerPrint'
  import inputNote from './inputNote'
  import printReceipt from './printReceipt'

  export default {
    components: {
      readIDCard,
      fingerPrint,
      inputNote,
      printReceipt,
    },
    data () {
      return {
        msg: 'default',
        second: '',
        flag: true
      }
    },
    props: ['compName'],
    methods: {},
    watch: {
      compName(){
        console.log('[ATM]:Navigated to ' +'/modules/(shared/)'+ this.compName+'.vue');
      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .body {
    height: 100%;
  }

  a {
    color: #42b983;
  }

  .page-enter-active {
    animation-delay: 0.1s;
    animation-duration: .7s;
    animation-fill-mode: both;
    animation-name: fadeInUp;
  }

  @keyframes fadeInUp {
    0% {
      opacity: 0;
      transform: translate3d(0, 100%, 0);
    }
    50% {
      opacity: 0;
      transform: translate3d(0, 100%, 0);
    }
    to {
      opacity: 1;
      transform: none;
    }
  }

  .page-leave-active {
    animation-duration: .6s;
    animation-fill-mode: both;
    animation-name: fadeOutUp;
  }

  @keyframes fadeOutUp {
    from {
      opacity: 1;
    }
    to {
      opacity: 0;
      transform: translate3d(0, -100%, 0);
    }
  }
</style>
