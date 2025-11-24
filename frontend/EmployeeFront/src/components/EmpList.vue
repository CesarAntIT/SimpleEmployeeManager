<script setup>
import {ref} from "vue";

    let arr = ref([]);

    function GetEmpList(){
        const gotList = 
        [
            {
                "id": "b3a903b1-0ba3-4638-b05b-8c15092c29a7",
                "firstName": "César",
                "lastName": "Aybar",
                "pay": 500,
                "birthDate": "2005-09-14T00:00:00",
                "hireDate": "2025-11-23T00:00:00",
                "department": "IT"
            },
            {
                "id": "0ba934da-66c8-4020-bb5d-12c188397d6e",
                "firstName": "Diego",
                "lastName": "Rodriguez",
                "pay": 450,
                "birthDate": "2003-10-13T00:00:00",
                "hireDate": "2025-11-23T00:00:00",
                "department": "MK"
            }
        ];

        arr.value = gotList; 
    }

</script>

<template>
    <div class="card">
        <button class="btn" v-on:click="GetEmpList()">Refresh</button>
        <button class="btn" style="background-color: lightgreen;">Add Employee</button>
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
