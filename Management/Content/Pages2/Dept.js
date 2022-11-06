var SaveDept = function () {
    var designation = $("#txtDesignation").val();
    var address = $("#txtAddress").val();
    var model = { Designation: designation, Address: address };

    $.ajax({
        url: "/Dept/SaveDept",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successfull");
        }
    })
};