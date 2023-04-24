<template>
  <div class="IASSectionComponent">
    <div v-for="(inputParam, index) in inputParams" :key="index" class="InputParameterComponent">
      <div class="row">
        <div class="column">
          <div class="label">Parameter:</div>
          <div class="control">
            <div v-for="(param, paramIndex) in inputParam.parameter" :key="paramIndex">
              <input v-model="inputParam.parameter[paramIndex]" v-on:change="addParameter(inputParam, paramIndex)" />
            </div>
            <div><input v-on:keyup.enter="addParameter(inputParam, inputParam.parameter.length)" placeholder="Add parameter"></div>
          </div>
        </div>
        <div class="column">
          <div class="label">Value:</div>
          <div class="control">
            <div v-for="(value, valueIndex) in inputParam.value" :key="valueIndex">
              <input v-model="inputParam.value[valueIndex]" v-on:change="addValue(inputParam, valueIndex)" />
            </div>
            <div><input v-on:keyup.enter="addValue(inputParam, inputParam.value.length)" placeholder="Add value"></div>
          </div>
        </div>
      </div>
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
    addParameter(inputParam, index) {
      if (!inputParam.parameter) {
        inputParam.parameter = [];
      }
      inputParam.parameter.splice(index + 1, 0, '');
      if (!inputParam.value) {
        inputParam.value = [];
      }
      inputParam.value.splice(index + 1, 0, '');
    },
    addValue(inputParam, index) {
      if (!inputParam.value) {
        inputParam.value = [];
      }
      inputParam.value.splice(index + 1, 0, '');
      if (!inputParam.parameter) {
        inputParam.parameter = [];
      }
      inputParam.parameter.splice(index + 1, 0, '');
    },
  },
};
</script>

<style scoped>
  .InputParameterComponent{
    display: flex;
    width: 100%;
  }

  .row {
    display: flex;
    align-items: center;
    padding: 20px;
    height: 50px;
  }

  .column {
    display: flex;
    flex-direction: column;
    width: 50%;
  }

  .label {
    font-size: 1rem;
  }

  .control {
    padding-top: 10px;
    padding-left: 11px;
    height: inherit;
  }

  input {
    width: 100%;
    height: 70%;
    padding-left: 15px;
  }

  button {
    height: 70%;
    margin-left: 10px;
  }
</style>