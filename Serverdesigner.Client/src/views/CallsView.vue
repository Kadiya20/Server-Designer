<script setup>
import Tree from 'primevue/tree';
import CallViewButtons from '../components/CallViewButtons.vue';
import 'primeicons/primeicons.css';
import EditCallComponent from '../components/EditCallComponent.vue';
import CallService from "../services/CallService.js";


</script>
<template>
    <div class="callsView">
        <div class="callsButtons">
            <CallViewButtons v-on:buttonClick="processButtonClick"></CallViewButtons>
        </div>
        <div class="callsContent">
            <div class="tree">
                <Tree ref="tree" v-model:selectionKeys="selectedKey" selectionMode="single" v-bind:value="treeNodes" v-on:node-select="onNodeSelect" >  
                </Tree>
             <div class="editarea" v-if="'data' in currentNode">
                <EditCallComponent v-bind:call="currentNode" v-on:change="updateTree"></EditCallComponent>
            </div>
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
    visibility: visible;
    
}
.editarea {
    flex-grow: 1;
}


</style>

<script>
export default {
    components: { CallViewButtons , Tree},
    data() {
        return {
            treeNodes: [],
            currentNode: {},
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
            if(button == "delete"){  
               this.deleteCall(this.currentNode);
            }
        },
        addCall() {
            CallService.addCall();
            this.treeNodes = CallService.getCalls();
        },
        onNodeSelect(node) {
            this.currentNode = node;
            this.$refs.tree.expandedKeys = [node.key];
        },
        updateTree() {
            this.treeNodes = CallService.getCalls();
        },
        deleteCall(call){
            CallService.deleteCall(call.data);
            this.treeNodes = CallService.getCalls();
        },
    },
};
</script>