<script setup>
import Tree from 'primevue/tree';
import CallViewButtons from '../components/CallViewButtons.vue';
import 'primeicons/primeicons.css';
import EditCallComponent from '../components/EditCallComponent.vue';
import CallService from "../services/CallService.js";
import InputParameterComponent from '../components/InputParamterComponent.vue';



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
                <!-- <div v-if="!showInputParameters"> -->
          <EditCallComponent v-bind:call="currentNode" v-on:change="updateTree"></EditCallComponent>
             <div v-if="currentNode.showInputParameters">
              <InputParameterComponent v-for="(inputParam, index) in currentNode.inputParameters" 
                            v-bind:key="index" v-bind:inputParam="inputParam"></InputParameterComponent>
             </div>
           <!-- </div>
        <div v-else>
          <InputParameterComponent v-for="(inputParam, index) in inputParams" v-bind:key="index" v-bind:inputParam="inputParam"></InputParameterComponent>
        </div> -->
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
            currentSelectedNodeIndex: null,
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
            }
            if(button == "delete"){  
               this.deleteCall(this.currentNode);
            }
            if (button === 'clone') {
                //   const clonedCall = CallService.cloneCall(this.currentNode.data);
                  CallService.cloneCall(this.currentNode.data);
                 this.treeNodes = CallService.getCalls();
                 }
            if (button == 'inputParams') {
                console.log("Inputparams is clickable!!");
                this.addInputParameter(this.currentNode);
                this.treeNodes = CallService.getCalls();
             }
            if (button == 'azLogin') {
                console.log("azLogin Btn clicked");
                    console.log("currentNode is not null, CallsView.addAzureAD starts");
                    this.addAzureAD(this.currentNode);
                    this.treeNodes = CallService.getCalls();
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
        },
        updateTree() {
            this.treeNodes = CallService.getCalls();
        },
        btnUpClick() {

            let oldIndex = this.currentSelectedNodeIndex; 
            console.log("oldIndex : " + oldIndex);
            let beforeIndexNode = CallService.calls.at(oldIndex - 1); 
            console.log("beforeIndexNode: " + beforeIndexNode);

            CallService.calls[oldIndex - 1] = CallService.calls.at(oldIndex); 
            CallService.calls[oldIndex] = beforeIndexNode;
            console.info(CallService.calls);
            this.treeNodes = CallService.getCalls();
        },
        btnDownClick() {
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
            if (call === this.currentNode) {
             this.currentNode = {}; // clear the edit area
           }
            this.treeNodes = CallService.getCalls();
            console.info(CallService.calls);
        },
        addInputParameter(call) {
          CallService.addInputParameter(call.data);
        },
        addAzureAD(call) {
            console.log("---CallsView.addAzureAD starts---");
                CallService.addAzureAD(call.data);
        }


    //   removeInputParameter(parameter) {
    //        const index = this.currentNode.inputParameters.indexOf(parameter);
    //        if (index > -1) {
    //       this.currentNode.inputParameters.splice(index, 1);
    //            }            
    //     },

    },
};
</script>