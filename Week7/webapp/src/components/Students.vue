<template>
    <div>
        <div v-if='operation == "list"'>
            <h2 class='section-heading'>Students</h2>
            <table>
                <thead>
                    <tr>
                        <th>Student Id</th>
                        <th>Email</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="student in students" :key="student.studentId">
                        <td>{{ student.studentId }}</td>
                        <td>${{ student.Email_Address }}</td>
                        <td>
                            <button v-on:click='displayStudentDetails(student.studentId)'>Details</button>
                            <button v-on:click='displayUpdateStudent(student.studentId)'>Update</button>
                            <button v-on:click='deleteStudent(student.studentId)'>Delete</button>
                        </td>
                    </tr>
                </tbody>
            </table>

            <button id='addBtn' v-on:click='displayAddStudent()'>Add Student</button>
        </div>

        <div v-if='operation == "add"'>
            <h2 class='section-heading'>Add Student</h2>
        
            <form>
                <div class='form-entry'>
                    Email: <input type='text' v-model='Email_Address'/>
                </div>

                <div class='form-entry'>
                    <button v-on:click='addStudent'>Add Student</button>
                    <button v-on:click='cancel'>Cancel</button>
                </div>
            </form>

        </div>

        <div v-if='operation == "detail"'>
            <h2 class='section-heading'>Student Detail</h2>

            <div class='form-entry'>
                Student: {{ Email_Address }}
            </div>

            <div class='form-entry'>
                <button v-on:click='cancel'>Ok</button>
            </div>
        </div>

        <div v-if='operation == "update"'>
            <h2 class='section-heading'>Update Student</h2>
        
            <form>
                <div class='form-entry'>
                    Email: <input type='text' v-model='Email_Address'/>
                </div>

                <div class='form-entry'>
                    <button v-on:click='updateStudent'>Update Student</button>
                    <button v-on:click='cancel'>Cancel</button>
                </div>
            </form>
        </div>
    </div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Products',
        
        data () {
            return {
                students: [],
                operation: 'list',
                name: undefined,
                price: undefined,
                count: undefined,
                productUpdateId: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
        methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            getStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/student/${studentId}`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.studentId = response.data.studentId;
                        this.Email_Address = response.data.Email_Address;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            displayAddStudent: function() {
                this.studentId = undefined;
                this.Email_Address = undefined;
                this.operation = 'add';
            },
            addStudent: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.post(url, {
                    studentId: this.studentId,
                    Email_Address: parseFloat(this.Email_Address),
                    count: parseInt(this.count)
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            displayStudentDetails: function(studentId) {
                this.getStudent(studentId);
                this.operation = 'detail';
            },
            displayUpdateStudent: function(studentId) {
                this.studentUpdateId = studentId;
                this.getStudent(studentId);
                this.operation = 'update';
            },
            updateStudent: function() {
                let url = `http://${this.apiServer}/api/student/${this.studentUpdateId}`;
                Vue.axios.put(url, {
                    studentId: this.studentId,
                    Email_Address: parseFloat(this.Email_Address),
                    count: parseInt(this.count)
                }).then(
                    () => {
                        this.getStudent();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            deleteStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/student/${studentId}`;
                Vue.axios.delete(url).then(
                    () => {
                        this.getStuents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            cancel: function() {
                this.operation = 'list';
            }
        },
        mounted() {
            this.getStudents();
            this.operation = 'list';
        }
    }
</script>

<style scoped>
    table {
        border-collapse: collapse;
    }
    table, th, td {
        border: 1px solid black;
        padding: 10px;
    }
    #addBtn {
        margin-top: 20px;
    }
    .form-entry {
        margin-top: 20px;
    }
</style>
