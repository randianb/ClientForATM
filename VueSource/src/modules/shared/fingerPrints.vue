<template>
  <div>
    <div>fingerprints{{d}}</div>
    <button @click="b">submit data</button>
  </div>
</template>

<script>
  //  import t from '../device/test'

  export default {
    components: {
    },
    data () {
      return {
        msg: 'default',
        second: '',
        flag: true
      }
    },
    props:['dataContext'],
    created(){

    },
    methods: {
      b(){
        this.$root.dataHub.$emit('data',{prints:'base64'});
      }
    },
    computed:{
      d(){
        return this.dataContext;
      }
    }
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
