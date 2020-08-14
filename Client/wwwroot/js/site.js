// Show Password
function showPassword(button) {
	var inputPassword = $(button).parent().find('input');
	if (inputPassword.attr('type') === "password") {
		inputPassword.attr('type', 'text');
	} else {
		inputPassword.attr('type', 'password');
	}
}

$('.show-password').on('click', function () {
	showPassword(this);
})
