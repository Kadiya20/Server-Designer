<script setup>
</script>
<template>
    <div class="navigationBar">
        <div id="top-menu-area" class="container-fluid">
        <div id="first-btn-section" class="btn-section">
        <button v-on:click="$emit('buttonClick', 'new')">
            <img src="@/assets/images/1202-plus-sign-add-design.png" class="btn-col"/>Add Call
        </button>
        </div>

        <div class="vl"></div>

        <div id="second-btn-section" class="btn-section">
            <button>
                <img src="@/assets/images/inputParamIcon.png" class="btn-col" />Input Parameters
            </button>
            <button>
                <img src="@/assets/images/azure.png" alt="AzureAD Login" class="btn-col" />AzureAD Login
            </button>
            <button>
                <img src="@/assets/images/Keys_1.png" class="btn-col" />Service HeaderLogin
            </button>
        </div>

        <div class="vl"></div>

        <div id="third-btn-section" class="btn-section">
            <button v-on:click="$emit('buttonClick', 'up')">
                <img src="@/assets/images/up.png" class="btn-col" />Up
            </button>
            <button v-on:click="$emit('buttonClick', 'down')">           
                <img src="@/assets/images/down.png" class="btn-col" />Down
            </button>
            <button v-on:click="$emit('buttonClick', 'delete')">
                <img src="@/assets/images/delete.png" class="btn-col" />Delete
            </button>
            <button v-on:click="$emit('buttonClick', 'clone')">
                <img src="@/assets/images/clone.png" class="btn-col" />Clone
            </button>
            <button>
                <img src="@/assets/images/Rename.png" class="btn-col" />Rename 
            </button>
        </div>

        <div class="vl"></div>

        <div id="fourth-btn-section" class="btn-section">
            <button>
                <img src="@/assets/images/SharePoint2019.png" class="btn-col" alt="Sharepoint Action"/>Sharepoint Action
            </button>
            <button ID="btnSave" class="btn-col">
                <img src="@/assets/images/icon2.png" class="btn-col" alt="Save Action">SaveAction
            </button>
            <button ID="btnEmail" class="btn-col">
                <img src="@/assets/images/icon3.png" class="btn-col" alt="Email Action">EamilAction 
            </button>
            <button>
                <img src="@/assets/images/icon4.png" class="btn-col">ReturnAction 
            </button> 
            <button>
                <img src="@/assets/images/icon5.png" class="btn-col">PrintAction 
            </button>
            <button>
                <img src="@/assets/images/icon6.png" class="btn-col">SQLAction
            </button> 
        </div>

        <div id="fifth-btn-section" class="btn-section">
            <button>
                <img src="@/assets/images/icon7.png" class="btn-col" alt="Sharepoint Action"/>DocuSignAction
            </button>
            <button>
                <img src="@/assets/images/icon8.png" class="btn-col" alt="Save Action">CRMOutputAction
            </button>
            <button ID="btnEmail" class="btn-col">
                <img src="@/assets/images/icon10.png" class="btn-col" alt="Email Action">AzureBlobStorageAction 
            </button>
        </div>
    </div>
    </div>
</template>
<style scoped>
#top-menu-area {
    /* position */
    position: relative;
    width: 100%;
    max-height: 200px !important; /* 18%*/
    /* Layout Model */
    display: flex;
    flex-direction: row !important;
    flex-wrap: nowrap;
    /*justify-content: space-between;*/
    align-items: center;
    /* Box Model */
    margin-top: 29px;
    margin-bottom: 10px;
    border-top: none;
    /*margin-top: 30px;*/
    /* Font */
    /* background style*/
    background-color: #F1F1F1;
}
.navigationBar {
    display: flex;
    column-gap: 0.5rem;
}
.btn-section{
    display: flex;
    flex-direction: row;
    padding-left: 10px;
    padding-right: 10px;
}
.btn-col {
    display: flex;
    height: 80px;
    align-items: center;
    flex-direction: column;
    margin: .5em .5em;
    padding: .25em .25em;
    text-decoration: none;
    text-align: center;
    font-size: 1em;
    color: #707070;
}
.vl {
    border-left: 1px solid darkgrey;
    height: 95%;
    position: relative;
    top: 0;
    z-index: 1;
}
button {
    border: none;
    background-color: inherit;
    color: #707070;
}
.navigationBar button img {
    width:64px;
    border: none;
    background-color: inherit;
}
</style>
<script>
export default {};
</script>