<script setup>
import {onMounted, ref} from "vue";
import EmpForm from "./EmpForm.vue";

    let arr = ref([]);
    let show_form = ref(0);

    onMounted(() => {
        GetEmpList();
    });

    function GetEmpList(){
        fetch("http://localhost:5160/api/Employee")
            .then (res => {
                if (!res.ok){
                    throw new Error("Could not fetch data")
                }
                return res.json();
            })
            .then(data => {
                console.log(data);
                arr.value = data;
            });
    }

    

</script>

<template>
    <div class="card">
        <button class="btn" v-on:click="GetEmpList()">Refresh</button>
        <EmpForm  v-if="show_form" v-on:close="show_form=0"/>
        <button class="btn" style="background-color: lightgreen;" v-on:click="show_form = 1">Add Employee</button>
        <table>
            <tr>
                <th>Firstname</th>
                <th>Lastname</th>
                <th>Hire Date</th>
                <th>Department</th>
                <th>Wage</th>
                <th></th>
            </tr>
            <tr v-for="val in arr">
                <td>{{ val.firstName }}</td>
                <td>{{ val.lastName }}</td>
                <td>{{new Date(val.hireDate).toDateString() }}</td>
                <td>{{ val.department }}</td>
                <td>USD$ {{ val.pay }}</td>
                <td>
                    <button class="btn" style="background-color:cadetblue;">Edit</button>
                    <button class="btn" style="background-color:lightcoral;">Elim</button>
                </td>
            </tr>
        </table>
    </div>
    
</template>

<style scoped>

table{
  border-width: 2px;
  border-style: dashed;
  background-color: lightgray;
  border-radius: 10px;
  padding: 20px;
  margin: 1rem;
}

tr{
  background-color: grey;
}

td,th{
  padding:5px;
  border-style: hidden;
  border-radius: 5px;
}

th{
    border-bottom-left-radius: 0px;
    border-bottom-right-radius: 0px;
}

button{
    padding: 0.5rem;
    border-radius: 5px;
    border-color: gray;
    margin: 5px;
}

</style>
