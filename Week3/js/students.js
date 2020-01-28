var students = '{"students": [{"id": "Student ID", "email": "Email Address" },\
 {"id": 356785, "email": "Thisoneemail@gmal.com"}\
 {"id": 164857, "email": "Anotherstudent@hotmail.com"}\
 {"id": 201385, "email": "Emailemail@email.com"}\
 {"id": 972035, "email": "Mynbox@protonmail.com"}\
 {"id": 701803, "email": "Lastone@gmail.com"}\
]}'


function returnStudents() 
{
    return JSON.parse(students);
}

function displayStudents(input) {
    var tableList = "";
    for(i = 0; i < input.length; i++) {
        var id = input[i].id;
        var email = input[i].email;
        tableList += "<tr><td>" + id + "</td><td>" + email + "</td>";

        document.getElementById("student-list").innerHTML = tableList;
    }
}

function populateTable()
{
    var data = returnStudents();
    displayStudents(data.students);
}


