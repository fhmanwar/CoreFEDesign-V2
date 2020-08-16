function Login() {
    //debugger;
    var validate = new Object();
    validate.uname = $('#username').val();
    validate.pass = $('#password').val();
    $.ajax({
        type: 'POST',
        url: "/validate/",
        cache: false,
        dataType: "JSON",
        data: validate
    }).then((result) => {
        //debugger;
        if (result.status == true) {
            window.location.href = "/";
        } else {
			$.notify({
				// options
				icon: 'flaticon-alarm-1',
				title: 'Notification',
                message: result.msg,
			}, {
				// settings
				element: 'body',
				type: "danger",
				allow_dismiss: true,
				placement: {
					from: "top",
					align: "center"
				},
				timer: 1000,
				delay: 5000,
				animate: {
					enter: 'animated fadeInDown',
					exit: 'animated fadeOutUp'
				},
			});
        }
    })
}

function Register() {
    if ($('#confirmPass').val() == $('#Pass').val()) {
        //debugger;
        var auth = new Object();
        auth.name = $('#Name').val();
        auth.uname = $('#Uname').val();
        auth.mail = $('#Email').val();
        auth.pass = $('#Pass').val();
        $.ajax({
            type: 'POST',
            url: "/validate/",
            cache: false,
            dataType: "JSON",
            data: auth
        }).then((result) => {
            //debugger;
            if (result.status == true) {
                $.notify({
                    // options
                    icon: 'flaticon-alarm-1',
                    title: 'Notification',
                    message: result.msg,
                }, {
                    // settings
                    element: 'body',
                    type: "success",
                    allow_dismiss: true,
                    placement: {
                        from: "top",
                        align: "center"
                    },
                    timer: 1000,
                    delay: 5000,
                    animate: {
                        enter: 'animated fadeInDown',
                        exit: 'animated fadeOutUp'
                    },
                });
                window.location.href = "/";
            } else {
                $.notify({
                    // options
                    icon: 'flaticon-alarm-1',
                    title: 'Notification',
                    message: result.msg,
                }, {
                    // settings
                    element: 'body',
                    type: "danger",
                    allow_dismiss: true,
                    placement: {
                        from: "top",
                        align: "center"
                    },
                    timer: 1000,
                    delay: 5000,
                    animate: {
                        enter: 'animated fadeInDown',
                        exit: 'animated fadeOutUp'
                    },
                });
            }
        })
    } else {
        $.notify({
            // options
            icon: 'flaticon-alarm-1',
            title: 'Notification',
            message: 'Password Not Same',
        }, {
            // settings
            element: 'body',
            type: "warning",
            allow_dismiss: true,
            placement: {
                from: "top",
                align: "center"
            },
            timer: 1000,
            delay: 5000,
            animate: {
                enter: 'animated fadeInDown',
                exit: 'animated fadeOutUp'
            },
        });
    }
}