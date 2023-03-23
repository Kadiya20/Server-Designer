<template>
    <div class="editCallComponent">
        <!-- {{ call.label }} -->
        <div class="row">
            <div class="label">Name:</div>
            <div class="control"><input v-model="call.data.name" v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Operation:</div>
            <div class="control"><input v-model="call.data.operation" v-on:change="$emit('change')" /></div>
        </div>
        <div class="row">
            <div class="label">Template path:</div>
            <div class="control"><input v-model="call.data.templatePath" v-on:change="$emit('change')" /></div>
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
export default {
    props: {
        call: Object
    },
    mounted() {
    }
}
</script>
