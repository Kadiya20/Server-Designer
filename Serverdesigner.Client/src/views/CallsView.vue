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
                <Tree selectionMode="single" v-bind:value="treeNodes" v-on:node-select="onNodeSelect" >  
                </Tree>
            </div>
             <div class="editarea" v-if="'data' in currentNode">
                <EditCallComponent v-bind:call="currentNode" v-on:change="updateTree"></EditCallComponent>
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
    flex-direction: row;
    height: 80vh;
    flex-wrap: nowrap;
    border: 1px lightgrey solid;
}
.tree {
    /* flex: 0 1 30em;
    visibility: visible; */
    width: 33%;
border-right: 1px lightgrey solid;
background-color: white;
resize: horizontal;
overflow: auto;
    
}

.p-tree {
    border: none;
}
.editarea {
    width: 33%;
border-right: 1px lightgrey solid;
background-color: #fff;
resize: horizontal;
overflow: hidden;
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
        //CallService.getCalls().then((data) => (this.treeNodes = data));
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
        updateTree() {
            this.treeNodes = CallService.getCalls();
        }
    },
};
</script>