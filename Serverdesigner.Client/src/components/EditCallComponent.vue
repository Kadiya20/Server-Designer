<template>
    <div class="editCallComponent">
        {{ call.label }}
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

<script>
export default {
    props: {
        call: Object
    },
    mounted() {
    }
}
</script>
