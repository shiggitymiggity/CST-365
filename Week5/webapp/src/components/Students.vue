<template>
    <div>
        <h2 align="center" class='section-heading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>ID Number</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>                   
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: 'Tables',
        mounted() {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }
    function getStudents() {
        return JSON.parse(students);
    }

    var students = '[{"id": 356785, "email": "Thisoneemail@gmal.com"},\
                    {"id": 164857, "email": "Anotherstudent@hotmail.com"},\
                    {"id": 201385, "email": "Emailemail@email.com"},\
                    {"id": 972035, "email": "Mynbox@protonmail.com"},\
                    {"id": 701803, "email": "Lastone@gmail.com"}]'
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
