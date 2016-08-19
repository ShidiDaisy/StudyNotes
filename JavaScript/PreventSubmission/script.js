// handle the form submit event
//<p><span id="errorMessage"></span></p>
function prepareEventHandlers() {
	document.getElementById("frmContact").onsubmit = function() {
		//When onsubmit event happens. we're going to execute this code
		// prevent a form from submitting if no email.
		if (document.getElementById("email").value == "") {
			document.getElementById("errorMessage").innerHTML = "Please provide at least an email address!";
			
			//return false to STOP the form from submitting
			return false;
		} else {
			// reset and allow the form to submit
			document.getElementById("errorMessage").innerHTML = "";
			return true;
		}
	};
}

// when the document loads
window.onload =  function() {
	prepareEventHandlers();
};

