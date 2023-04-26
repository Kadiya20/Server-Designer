<template>
  <div class="ParamValueComponent">
    <div v-for="(inputParam, index) in inputParams" :key="index" class="InputParameterComponent">
      <div class="row">
        <div class="column">
          <div class="label">Parameter:</div>
          <div class="control">
            <div v-for="(param, paramIndex) in inputParam.parameters" :key="paramIndex">
              <input v-model="inputParam.parameters[paramIndex]" v-on:keyup.enter="focusNextInput($event.target)" />
            </div>
            <div><input v-on:keyup.enter="addParameter(inputParam)" placeholder="Add parameter"></div>
          </div>
        </div>
        <div class="column">
          <div class="label">Value:</div>
          <div class="control">
            <div v-for="(value, valueIndex) in inputParam.values" :key="valueIndex">
              <input v-model="inputParam.values[valueIndex]" v-on:keyup.enter="focusNextInput($event.target)" />
            </div>
            <div><input v-on:keyup.enter="addParameter(inputParam)" placeholder="Add value"></div>
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
    addParameter(inputParam) {
      if (!inputParam.parameters) {
        inputParam.parameters = [];
      }
      if (!inputParam.values) {
        inputParam.values = [];
      }
      inputParam.parameters.push('');
      inputParam.values.push('');
    },
    focusNextInput(target) {
      if (target.nextElementSibling) {
        target.nextElementSibling.focus();
      } else {
        // If there is no next input, add a new key-value pair
        const inputParam = this.inputParams[this.inputParams.length - 1];
        this.addParameter(inputParam);
      }
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