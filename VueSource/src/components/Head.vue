<template>
  <header>
    <div @click="admin">
      <img src="../../static/logo.jpg"  alt="">
    </div>
  </header>
</template>

<script>
  export default {
    name: 'hell',
    data () {
      return {
        counter:0,
        time:null,
      }
    },
    methods:{
      admin(){
        if(this.counter==0)
          this.time=new Date().getSeconds();
        this.counter++;
//        console.log(this.time);
        if(this.counter>=4){
          this.counter=0;
          let newtime=new Date().getSeconds();
          if(newtime<this.time)
            newtime+=60;
          if(newtime-this.time<3){
            alert('admin');
          }
        }
      },

    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  header{
    width: 100%;
    background-color: #e74a41;
    height: 86px;
    text-align: left;
    vertical-align: middle;
  }
  img{
    display: inline-block;
    margin-top: 22px;

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
