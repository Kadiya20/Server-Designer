<template>
    <div class="editCallComponent">
        {{ call.label }}
        <div class="row">
            <div class="label">Name:</div>
            <div class="control"><input v-model="call.data.name" v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Operation:</div>
            <div class="control"><Dropdown  :options="operationOptions" v-model="call.data.operation" placeholder="  " v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Template path:</div>
            <div class="control"><FileUpload mode="basic" v-model="call.data.templatePath" accept=".doc,.docx,.pdf" v-on:change="$emit('change')" /></div>
        </div>
    </div>
</template>

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
