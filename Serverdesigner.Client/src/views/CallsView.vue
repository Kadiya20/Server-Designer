<script setup>
import Tree from 'primevue/tree';
import CallViewButtons from '../components/CallViewButtons.vue';
import EditCallComponent from '../components/EditCallComponent.vue';
import CallService from "../services/CallService.js"
</script>
<template>
    <div class="callsView">
        <div class="callsButtons">
            <CallViewButtons v-on:buttonClick="processButtonClick"></CallViewButtons>
        </div>
        <div class="callsContent">
            <div class="tree">
                <Tree selectionMode="single" v-bind:value="treeNodes"  v-on:node-select="onNodeSelect"></Tree>
            </div>
            <div class="editarea">
                <EditCallComponent v-bind:call="currentNode"></EditCallComponent>
            </div>
        </div>
    </div>
</template>

<style scoped>
.callsView {
    display: flex;
    flex-direction: column;
}
.callsContent {
    display: flex;
}
.tree {
    flex: 0 1 30em;
}
.editarea {
    flex-grow: 1;
}
</style>

<script>
export default {
    components: { CallViewButtons },
    data() {
        return {
            treeNodes: [],
            currentNode: {}
        };
    },
    mounted() {
        this.treeNodes = CallService.getCalls();
    },
    methods: {
        processButtonClick(button) {
            if (button == "new") {
                this.addCall();
            }
        },
        addCall() {
            CallService.addCall();
            this.treeNodes = CallService.getCalls();
        },
        onNodeSelect(node) {
            this.currentNode = node;
        },
    },
};
</script>