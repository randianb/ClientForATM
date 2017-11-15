<template>
  <div class="body">
    <transition mode="out-in" name="page">
      <component :dataContext="dataContext" :is="compName"></component>
    </transition>
  </div>
</template>

<script>
  import readIDCard from './readIDCard'
  import fingerPrints from './fingerPrints'

  export default {
    components: {
      'readIDCard':readIDCard,
      'fingerPrints':fingerPrints,
    },
    data () {
      return {
        msg: 'default',
        second: '',
        flag: true
      }
    },
    props: ['compName','dataContext'],
    created(){

    },
    methods: {}
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .body{
    height: 100%;
  }

  a {
    color: #42b983;
  }
  .page-enter-active {
    animation-delay: 0.1s;
    animation-duration: 0.6s;
    animation-fill-mode: both;
    animation-name: fadeInUp;
  }

  @keyframes fadeInUp {
    from {
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
