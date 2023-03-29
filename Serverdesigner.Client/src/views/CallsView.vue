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
                <Tree selectionMode="single" v-bind:value="treeNodes" v-on:node-select="onNodeSelect">  
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
            currentSelectedNodeIndex: null
        };
    },
    mounted() {

        //CallService.getCalls().then((data) => (this.treeNodes = data));
        // this.treeNodes = CallService.getCalls();
    },
    methods: {
        processButtonClick(button) {
            if (button == "new") {
                this.addCall();
            }
            if (button == "up") {
                if (this.treeNodes.length > 1 && this.currentSelectedNodeIndex != 0){
                    this.btnUpClick(this.currentNode);
                }
            }
            if (button == "down") {
                if (this.treeNodes.length > 1 && this.currentSelectedNodeIndex < (this.treeNodes.length-1)){
                    this.btnDownClick(this.currentNode);
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

            this.currentSelectedNodeIndex = this.treeNodes.indexOf(node);
            console.log("current selected node is : " + this.currentSelectedNodeIndex);
            console.log("treeNode length: " + this.treeNodes.length);
            
            this.$refs.tree.expandedKeys = [node.key];
        },
        updateTree() {
            this.treeNodes = CallService.getCalls();
        },
        btnUpClick(currentNode) {

            let oldIndex = this.currentSelectedNodeIndex; 
            console.log("oldIndex : " + oldIndex);
            let beforeIndexNode = CallService.calls.at(oldIndex - 1); 
            console.log("beforeIndexNode: " + beforeIndexNode);

            CallService.calls[oldIndex - 1] = CallService.calls.at(oldIndex); 
            CallService.calls[oldIndex] = beforeIndexNode;
            console.info(CallService.calls);
            this.treeNodes = CallService.getCalls();
        },
        btnDownClick(currentNode) {
            let oldIndex = this.currentSelectedNodeIndex; // 1
            console.log("oldIndex : " + oldIndex);
            let afterIndexNode = CallService.calls.at(oldIndex + 1); // 2  
            console.log("beforeIndexNode: " + afterIndexNode);

            CallService.calls[oldIndex + 1] = CallService.calls.at(oldIndex); // calls[2] = 1 
            CallService.calls[oldIndex] = afterIndexNode; // calls[1] = 2
            console.info(CallService.calls);
            this.treeNodes = CallService.getCalls();
        },
        deleteCall(call){
            CallService.deleteCall(call.data);
            this.treeNodes = CallService.getCalls();
        },
    },
};
</script>