<template>
  <div class="ParamValueComponent">
    <div class="InputParameterComponent">
      <div class="row">
        <div class="column">
          <div class="label">Parameter</div>
          <div class="control">
            <input v-model="newParam" class="input" placeholder="Enter parameter">
          </div>
        </div>
        <div class="column">
          <div class="label">Value</div>
          <div class="control">
            <input v-model="newValue" class="input" placeholder="Enter value">
          </div>
        </div>
        <div class="column">
          <button @click="addNewParam" class="button">Add</button>
        </div>
      </div>
    </div>
    <div v-for="(inputParam, index) in inputParams" :key="index" class="InputParameterComponent">
      <div class="row">
        <div class="column">
          <div class="input">{{ inputParam.parameter }}</div>
        </div>
        <div class="column line"></div>
        <div class="column">
          <div class="input">{{ inputParam.value }}</div>
        </div>
      </div>
    </div>
    <div v-if="errorMsg" class="error">{{ errorMsg }}</div>
  </div>
</template>

<script>
export default {
  props: {
    inputParams: Array,
  },
  data() {
    return {
      newParam: "",
      newValue: "",
      errorMsg: "",
    };
  },
  methods: {
    addNewParam() {
      const paramInput = this.newParam.trim();
      const valueInput = this.newValue.trim();

      if (!paramInput || !valueInput) {
        return;
      }

      const existingParam = this.inputParams.find(
        (inputParam) => inputParam.parameter === paramInput
      );

      if (existingParam) {
        this.errorMsg = "Parameter name already exists!";
        return;
      }

      this.inputParams.push({ parameter: paramInput, value: valueInput });
      this.newParam = "";
      this.newValue = "";
      this.errorMsg = "";
    },
  },
};
</script>

<style scoped>
  .ParamValueComponent {
    display: flex;
    flex-direction: column;
    margin: 10px;
  }

  .InputParameterComponent {
    border: 1px solid black;
    margin-bottom: 10px;
  }

  .row {
    display: flex;
    align-items: center;
    height: 50px;
  }

  .column {
    display: flex;
    flex-direction: column;
    width: 50%;
    position: relative;
  }

  .column.line::after {
    content: "";
    position: absolute;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    border-left: 1px solid black;
  }

  .label {
    font-size: 1rem;
    font-weight: bold;
    margin-bottom: 5px;
  }

  .control {
    display: flex;
    align-items: center;
    padding: 5px 10px;
    height: 100%;
  }

  input {
    width: 100%;
    height: 100%;
    padding-left: 10px;
    border: none;
    outline: none;
  }

  button {
    height: 100%;
    margin-left: 10px;
    background-color: #4caf50;
    color: white;
    border: none;
    outline: none;
    cursor: pointer;
    font-size: 1rem;
    font-weight: bold;
    padding: 5px 10px;
  }

  .error {
    color: red;
    margin-top: 10px;
  }
</style>

