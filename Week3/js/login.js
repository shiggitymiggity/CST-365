function validate() {
    
    document.getElementById('name-error').style.visibility = 'hidden'
    document.getElementById('password-error').style.visibility = 'hidden'

    let firstName = document.getElementById('name').value
    let lastName = document.getElementById('password').value

    if (firstName == '') {
        document.getElementById('name-error').style.visibility = 'visible'
    }

    if (lastName == '') {
        document.getElementById('password-error').style.visibility = 'visible'
    }
}