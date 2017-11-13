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
    methods: {
      da(){
        console.log(this.dataContext1);
      },
      async read () {
//      this.csharp.toVsBus('');
        var a11 = 3;
        a11 = await t.did().then((res) => {
          console.log(res);
        })
          .catch((err) => {
            console.log(err);
          });
//      var c=0;
//      for (var i = 0; i < 300000; i++) {
//        c++;
//      }
        console.log("in hello");
//      console.log(this.csharp);
        console.log(a11);
      },
      b(){
      },
      head1(){
        var aa = this;
        setTimeout(function () {
          aa.second = (new Date()).getMilliseconds().toString();
          aa.head1();
        }, 520);

      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .body{
    height: 580px;
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
