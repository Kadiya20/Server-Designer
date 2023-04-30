<template>
    <div class="editCallComponent">
        {{  }}
        <div class="row">
            <div class="label">Name:</div>
            <div class="control"><input v-model="call.name" v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Operation:</div>
            <div class="control"><Dropdown  :options="operationOptions" v-model="call.operation" placeholder="  " v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Template path:</div>
            <div class="control"><FileUpload mode="basic" v-model="call.templatePath" accept=".doc,.docx,.pdf" v-on:change="$emit('change')" /></div>
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
import FileUpload from "primevue/fileupload";

export default {
  components: {
    Dropdown,
    FileUpload,
  },
  props: {
    call: Object,
  },
  data() {
    return {
      operationOptions: ["GenerateDocument", "GenerateSpreadsheet", "GenerateSlides"],
    };
  },
};
</script>
