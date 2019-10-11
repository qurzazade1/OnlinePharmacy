var URL = '/Customer/CustomerOrder/GetCustomerOrderDetails';

$(function () {
    $(".anchorDetail").click(function () {

        var $bClicked = $(this);
        var id = $bClicked.attr('data-id');

        $.ajax({
            type: "GET",
            url: URL,
            contentType: "application/json; charset=utf-8",
            data: { "Id": id },
            cache: false,
            datatyype: "json",
            success: function (data) {
                $('#myOrderDetailsModalContent').html(data);
                $('#myOrderDetailsModal').modal('show');
            },
            error: function () {
                alert("Dynamic content load failed");
            }
        });

    });


});