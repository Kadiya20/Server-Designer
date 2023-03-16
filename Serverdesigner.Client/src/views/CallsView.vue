<script setup>
import Tree from 'primevue/tree';
import CallViewButtons from '../components/CallViewButtons.vue';
import 'primeicons/primeicons.css';
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
                <Tree selectionMode="single" v-bind:value="treeNodes" v-bind:expandedKeys="expandedNodes" v-on:node-select="onNodeSelect" v-on:node-toggle="onNodeToggle" ></Tree>
             <div class="editarea">
                <EditCallComponent v-bind:call="currentNode"></EditCallComponent>
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
            expandedNodes: []
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
            const newNode = this.treeNodes[this.treeNodes.length - 1];
            this.expandedNodes.push(newNode.key);
        },
        onNodeSelect(node) {
            this.currentNode = node;

        },
      onNodeToggle(node) {
             if (this.expandedNodes.includes(node.key)) {
                 // Node is already expanded, so collapse it
                   this.expandedNodes.splice(this.expandedNodes.indexOf(node.key), 1);
               } else {
                     // Node is not expanded, so expand it
                            this.expandedNodes.push(node.key);
                       }
        },


    },
};
</script>