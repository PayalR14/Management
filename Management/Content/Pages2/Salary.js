$(document).ready(function () {
    GetSalary();
});

var SaveSalary = function () {
    var designation = $("#txtDesignation").val();
    var salary = $("#txtsalary").val();
    var model = { Designation: designation, salary: salary };
    $.ajax({
        url: "/Salary/SaveSalary",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successfull");
        }
    });
}
var GetSalary = function () {
    debugger

    $.ajax({
        url: "/Salary/GetSalaryList",
        method: "Post",
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblSalary tbody").empty();
            // debugger
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id +
                    "</td><td>" + elementValue.Designation +
                    "</td><td>" + elementValue.salary + "</td></tr>";
            });
            $("#tblSalary tbody").append(html);
        }

    });
}