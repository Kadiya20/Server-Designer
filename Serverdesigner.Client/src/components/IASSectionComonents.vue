<template>
  <div class="IASSectionComponent">
    <div v-for="(inputParam, index) in inputParams" :key="index" class="InputParameterComponent">
      <div class="label">Parameter:</div>
      <div class="control"><input v-model="inputParam.parameter" v-on:change="updateInputParams" /></div>
      <div class="label">Value:</div>
      <div class="control"><input v-model="inputParam.value" v-on:change="updateInputParams" /></div>
    </div>
  </div>
</template>
  
<script>
export default {
  props: {
    inputParams: Array,
  },
  mounted() {

  },
  methods: {
    updateInputParams() {
      this.$emit('updateInputParams', this.inputParams);
    },
  },
};
</script>


  <style scoped>
   .InputParameterComponent{
        display: flex;
        flex-direction: column;
        width: 100%;

    }
    .row {
      display: flex;
      align-items: center;
      padding: 20px;
      height: 50px;
    }
  
    .row:nth-child(odd) {
      background-color: #f1f1f1;
    }
  
    .label {
      font-size: 1rem;
      width: 20%;
    }
  
    .control {
      padding-top: 10px;
      padding-left: 11px;
      width: 40%;
      height: inherit;
    }
  
    input {
      width: 85%;
      height: 70%;
      padding-left: 15px;
    }
  
    button {
      height: 70%;
      margin-left: 10px;
    }
  </style>
  
  
  
  