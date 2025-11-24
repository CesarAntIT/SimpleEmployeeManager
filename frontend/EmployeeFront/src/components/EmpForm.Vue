<script setup>
import {onMounted, ref} from "vue";
    const disabled = ref(0);
    const props = defineProps({
        edit: Boolean,
        id: String,
    })
    const emits = defineEmits(['close']);

    const Emp = ref({
        ID: '',
        firstName: '',
        lastName: '',
        BirthDate: '',
        hireDate: '',
        Pay: 0
    } ); 


</script>

<template>
    <div class="main-card">
        <h2>Add an Employee</h2>

            <div style="display: flex;">
            <div>
                <input type="text" hidden>
                <div>
                    <label for="">Name</label><br>
                    <input type="text" placeholder="Name" v-model="Emp.firstName">
                </div>
                <div>
                    <label for="">Lastname</label><br>
                    <input type="text" placeholder="Lastname" v-model="Emp.lastName">
                </div>
                <div>
                    <label for="">Birth Date</label><br>
                    <input type="date" v-model="Emp.BirthDate">
                </div>
                </div>

                <div>
                    <div>
                        <label for="">Department</label><br>
                        <input type="text" placeholder="Dep">
                    </div>
                    <div>
                        <label for="">Pay</label><br>
                        <input type="number" step="0.10" placeholder="USD$">
                    </div>

                    <button v-on:click="$emit('close')">Cancel</button>
                    <button v-if="!edit" style="background-color: lightgreen;" 
                            :disabled="disabled" 
                            v-on:click="console.log(Emp)">Add</button>
                    <button v-if="edit" style="background-color: lightgreen;" 
                            :disabled="disabled" 
                            v-on:click="console.log(Emp)">Edit</button>
                </div>
            </div>
        
    </div>
</template>

<style lang="less" scoped>

.main-card{
    position: absolute;
    background-color: white;
    box-shadow: 2px 5px 30px;
    padding: 2em;
    border-radius: 1rem;
    width: 50%;

    input{
        padding: 10px;
        margin: 1px;
    }
    button{
        padding: 0.5rem;
        border-radius: 5px;
        border-color: gray;
        margin: 5px;
    }
}

</style>

