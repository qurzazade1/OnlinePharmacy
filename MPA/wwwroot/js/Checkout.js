


function setMedicinePickUpTime() {
    var dateSelected = document.getElementById("textDate").value;
    var today = new Date();
    var dt = new Date(dateSelected);

    dt.setHours(0, 0, 0, 0);
    if (today<dt) {
        selectedTime = '11:00am';
    }
    else {
        selectedTime = getTimeFromCurrentDate();
    }

    $('#textTime').timepicker('option', 'minTime', selectedTime);

}


$(function () {
    var minDt = 0;
    if (getTimeFromCurrentDate >= 20) {
        minDt = 1;
    }

    $("#textTime").timepicker({ 'minTime': '11:00 AM', 'maxTime': '9:00 PM', step: '30' })

    $("#textDate").datepicker({ minDate: minDt, maxDate: "+1W" });


});





function validateUserInput() {
    var dt = document.getElementById("textDate").value;
    var customerName = document.getElementById("txtName").value;
    var phone = document.getElementById("txtPhone").value;
    var time = document.getElementById("textTime").value;
    if (customerName.toString() == '') {
        alert("Please enter pickup name");
        return false;
    }
    else {
        if (dt.toString() == '') {
            alert("Please select pickup Date");
            return false;
        }
        else {
            


            if (time.toString() == '') {
                alert("Please select pickup time");
                return false;
            }


            else {
                if (phone.toString() == '') {
                    alert("Please enter phone number");
                    return false;
                }
                else {


                    
                    if (textPickupAddress.toString() == '') {
                        alert("Please enter PickUp Address ");
                        return false;
                    }

                    else {
                       
                        return true;
                    }
                }
            }
        }
    }
}

function getTimeFromCurrentDate() {
    var curDt = new Date();
    var minTime = "";
    if (curDt.getHours() < 11) {
        minTime = '12:00pm';
    }
    else {
        if (curDt.getMinutes() < 30) {
            minTime = (curDt.getHours() + 1).toString() + ':30pm'
        }
        else {
            minTime = (curDt.getHours() + 2).toString() + ':00pm'
        }
    }
    return minTime;
}

$('textDate').change(function () {
    setMedicinePickUpTime();
});

