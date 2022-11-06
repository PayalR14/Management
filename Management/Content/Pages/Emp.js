var SaveEmp = function () {
    var emp_name = $("#txtName").val();
    var email = $("#txtEmail").val();
    var address = $("#txtAddress").val();
    var model = { Emp_name: emp_name, Email: email, Address: address };
    $.ajax({
        url: "/Emp/SaveEmp",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successfully");
        }
    })
};