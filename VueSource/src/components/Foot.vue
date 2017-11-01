<template>
  <footer>
    <img src="../../static/footerbg.png" alt="">
    <div class="ad">网址：http://www.bjrcb.com
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      热线：4006696198</div>
  </footer>
</template>

<script>
  export default {
    name: 'hell',
    data () {
      return {
      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  footer{
    text-align: center;
    position: absolute;
    bottom: 0;
  }
  img{
    height: 110px;
    width: 100%;
  }
  .ad{
    position: absolute;
    bottom: 25px;
    color: white;
    width: 100%;
    font-size: 14px;
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
