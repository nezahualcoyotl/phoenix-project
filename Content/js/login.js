function Validate() {
    $.ajax(
    {
        type: "POST",
        url: '/User/Validate',
        data: {
            username: $('#username').val(),
            password: $('#password').val()
        },
        error: function () {
            alert("There is a Problem, Try Again!");
        },
        success: function (result) {
            console.log(result);
            if (result.status == true) {
                window.location.href = "/Home/Index";
            }
            else {
                alert(result.message);
            }
        }
    });
}