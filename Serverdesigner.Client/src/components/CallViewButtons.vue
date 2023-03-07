<script setup>
</script>
<template>
    <div class="navigationBar">
        <button v-on:click="$emit('buttonClick', 'new')">
            <img src="@/assets/images/1202-plus-sign-add-design.png" />
        </button>
        <button>
            <img src="@/assets/images/inputParamIcon.png" class="btn-col" />
        </button>
        <button><img src="@/assets/images/azure.png" alt="AzureAD Login" class="btn-col" />AzureAD Login</button>
        <button>
            <img src="@/assets/images/SharePoint2019.png" class="btn-col" />
        </button>
        <button>
            <img src="@/assets/images/up.png" class="btn-col" />
        </button>
        <button>
            <img src="@/assets/images/down.png" class="btn-col" />
        </button>
        <button>
            <img src="@/assets/images/delete.png" class="btn-col" />
        </button>
        <button>
            <img src="@/assets/images/clone.png" class="btn-col" />
        </button>
        <button>
            <img src="@/assets/images/Rename.png" class="btn-col" />
        </button>
    </div>
</template>
<style scoped>
.navigationBar {
    display: flex;
    column-gap: 0.5rem;
}
.navigationBar button img {
    width:64px;
}
</style>
<script>
export default {};
</script>