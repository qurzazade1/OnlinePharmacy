$(function () {
    var DiscountCodeString = document.getElementById("txtDiscountCodeString").value;

    if (DiscountCodeString.length > 0) {
        document.getElementById('btnDiscountCode').style.display = 'none';
        document.getElementById('btnRemoveDiscountCode').style.display = '';
    }
    else {
        document.getElementById('btnDiscountCode').style.display = '';
        document.getElementById('btnRemoveDiscountCode').style.display = 'none';
    }
});
