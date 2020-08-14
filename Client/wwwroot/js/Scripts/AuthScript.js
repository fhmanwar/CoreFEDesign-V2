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
            window.location.href = "/home";
        } else {
			$.notify({
				// options
				icon: 'flaticon-alarm-1',
				title: 'Notification',
                message: result.msg,
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
    })
}