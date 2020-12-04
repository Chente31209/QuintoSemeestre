<template>
  <h1>{{ msg }}</h1>
  <p>18040071</p>
  <button @click="count++">Aumentar</button>
  <p>Numero Normal: {{count}} X2 {{count*2}} X3 {{count*3}} </p>
  <button @click="count=0">Reinicar</button>
  
</template>

<script>
export default {
  
  name: 'HelloWorld',
  props: {
    msg: String
  },
  data() {
    return {
      count: 0
    }
  }
}
</script>
