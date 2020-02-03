function validate() {
    
    document.getElementById('name-error').style.visibility = 'hidden'
    document.getElementById('password-error').style.visibility = 'hidden'

    var firstName = document.getElementById('name').value
    var lastName = document.getElementById('password').value

    if (firstName == '') {
        document.getElementById('name-error').style.visibility = 'visible'
    }

    if (lastName == '') {
        document.getElementById('password-error').style.visibility = 'visible'
    }
}