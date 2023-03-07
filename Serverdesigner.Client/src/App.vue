<script setup>
import NavigationBar from './components/NavigationBar.vue';
</script>

<template>
    <div id="appContainer">
        <!-- Todo: If not authenticated, only show the login screen -->
        <nav>
            <NavigationBar></NavigationBar>
        </nav>
        <main>
            <router-view></router-view>
        </main>
    </div>
</template>

<script>
export default {

};
</script>

<style scoped>
#appContainer {
    display: flex;
    flex-direction: column;
}

nav {
    flex: 0 0 3em;
    background-color: lightgray;
}

main {
    flex-grow: 1;
}
</style>
