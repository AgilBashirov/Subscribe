// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    $('#add').on('click', function (e) {
        e.preventDefault();

        let email = $(".form-control").val();

        console.log(email);

        $.ajax({

            url: "/home/addSubscriber/",
            type: "post",
            dataType: "json",

            data: { email: email },
            success: function (response) {

                if (response == 200) {

                    console.log("Email elave olundu");
                }
                else {
                    console.log("Email elave olunmadi, Duz yaz");

                }


            },
            error: function (response) {

                console.log("error: " + response);
            }

        });

    });

})

