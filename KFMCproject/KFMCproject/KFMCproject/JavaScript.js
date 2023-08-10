let hidden = false;



function hideAction() {
    hidden = !hidden;
    if (hidden) {
        document.getElementById('registrationButton').style.visibility = 'hidden';
    } else {
        document.getElementById('Button12').style.visibility = 'visible';
    }
}