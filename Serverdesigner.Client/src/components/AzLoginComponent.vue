<template>
    <div class="azLoginComponent">
        {{  }}
        <div class="row">
            <div class="label">Parameter</div>
            <div class="label">Value</div>
        </div>
        <div class="row">
            <div class="label">Mode:</div>
            <div class="control"><Dropdown :options="modeOptions" v-model="azLoginComponent.data.modeOptions" placeholder="  " v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Login Behaviour:</div>
            <div class="control"><Dropdown :options="loginBehaviorOptions" v-model="azLoginComponent.data.loginBehaviorOptions" placeholder="  " v-on:change="$emit('change')" /></div>
        </div>
    </div>
</template>
<style scoped>
    .editCallComponent {
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

    .row:nth-child(odd){
        background-color: #F1F1F1;
    }

    .label {
        font-size: 1rem;
        width: 20%;
    }

    .control {
        padding-top: 10px;
        padding-left: 11px;
        width: 100%;
        height: inherit;
    }

    input {
        width: 85%;
        height: 70%;
        padding-left: 15px;
    }

</style>

<script>
import Dropdown from 'primevue/dropdown';

export default {
  components: {
    Dropdown,
  },
  props: {
    azLoginComponent: Object,
  },
  data() {
    return {
      modeOptions: ["AzureAD Login", "AzureAD Access Token"],
      loginBehaviorOptions: ["Auto", "Always Ask"]
    };
  },
};
</script>
