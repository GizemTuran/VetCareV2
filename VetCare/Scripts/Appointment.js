function buttonFunction() {
    console.log("HHEEEYY!!!!");
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