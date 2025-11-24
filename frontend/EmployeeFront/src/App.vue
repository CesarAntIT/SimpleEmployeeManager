<script setup>
import EmpList from './components/EmpList.vue';
import HelloWorld from './components/HelloWorld.vue'
import Topbar from './components/Topbar.vue';
import EmpForm from './components/EmpForm.vue';
import EmpRemove from './components/EmpRemove.vue';
</script>

<template>
  <Topbar/>
  <EmpList/>
</template>

<style scoped>
body{
  background-color: white;
}
</style>
