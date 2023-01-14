function buttonFunction() {
    var name = document.getElementById("fname").value;
    var phone = document.getElementById("fphone").value;
    var email = document.getElementById("femail").value;
    var reason = document.getElementById("freason").value;
    var gender = document.getElementById("fgender").value;
    var date = document.getElementById("fdate").value;

    console.log(name);
    console.log(phone);
    console.log(email);
    console.log(reason);
    console.log(gender);
    console.log(date);


    if (document.Appointment.Name == "") {
        alert("Please provide your name");
        document.Appointment.Name.focus();
        return false;
    }
    if (document.Appointment.Phone == "") {
        alert("Please provide your phone");
        document.Appointment.Phone.focus();
        return false;
    }
    if (document.Appointment.Email == "") {
        alert("Please provide your email");
        document.Appointment.Email.focus();
        return false;
    }
    if (document.Appointment.Date == "") {
        alert("Please provide your date");
        document.Appointment.Date.focus();
        return false;
    }
    if (document.Appointment.Gender == "") {
        alert("Please provide your gender");
        document.Appointment.Gender.focus();
        return false;
    }
    if (document.Appointment.Reason == "") {
        alert("Please provide your reason");
        document.Appointment.Reason.focus();
        return false;
    }

}