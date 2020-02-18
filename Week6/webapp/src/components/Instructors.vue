<template>
    <div>
        <h2 align="center" class='section-heading'>Instructors</h2>
        <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructors in instructors" v-bind:key="instructors">
                    <td>{{ instructors.first }}</td>
                    <td>{{ instructors.middle }}</td>
                    <td>{{ instructors.last }}</td>                   
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: 'Tables',
        mounted() {
            this.instructors = getinstructors();
        },
        data () {
            return {
                instructors: []
            }
        }
    }
    function getinstructors() {
        return JSON.parse(instructors);
    }

    var instructors = '[{"first": "Kajetan", "middle": "A.", "last": "Savage"}, \
                        {"first": "Evelina", "middle": "T.", "last": "Almond"}, \
                        {"first": "Orlaith", "middle": "L.", "last": "Wilde"},\
                        {"first": "Alfie", "middle": "Q.", "last": "Santiago"},\
                        {"first": "Gail", "middle": "U.", "last": "Stark"}]'
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
