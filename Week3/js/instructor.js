var instructors = '{"instructors": [{"first": "First Name", "middle": "Middle Initial", "last": "Last Name"},\
 {"first": "Kajetan", "middle": "A.", "last": "Savage"},\
 {"first": "Evelina", "middle": "T.", "last": "Almond"},\
 {"first": "Orlaith", "middle": "L.", "last": "Wilde"},\
 {"first": "Alfie", "middle": "Q.", "last": "Santiago"},\
 {"first": "Gail", "middle": "U.", "last": "Stark"}]}'

function returnInstructors() 
{
    return JSON.parse(instructors);
}

function displayInstructors(input) {
    var tableList = "";
    for(i = 0; i < input.length; i++) {
        var firstName = input[i].first;
        var midInit = input[i].middle;
        var lastName = input[i].last;

        // make the first inputs headers
        if (i == 0)
        {
            tableList += "<tr><th>" + firstName + "</th><th>" + midInit + "</th><th>" + lastName + "</th>"; 
        }
        else
        {
        tableList += "<tr><td>" + firstName + "</td><td>" + midInit + "</td><td>" + lastName + "</td>";
        }

        document.getElementById("instructor-list").innerHTML = tableList;
    }
}

function populateTable()
{
    var data = returnInstructors();
    displayInstructors(data.instructors);
}