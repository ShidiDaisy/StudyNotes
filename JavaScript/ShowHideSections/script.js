// show and hide sections of a form
//A check box, that when I check it is activating or turning on another section of the form itself
function preparePage() {
	document.getElementById("brochures").onclick = function() {
		                    //"brochures": id of checkbox
		if (document.getElementById("brochures").checked) {
			// use CSS style to show it
			document.getElementById("tourSelection").style.display = "block";
									//"tourSelection": hiden sections
		} else {
			// hide the div
			document.getElementById("tourSelection").style.display = "none";
		}
	};
	// now hide it on the initial page load.
	document.getElementById("tourSelection").style.display = "none";
}

window.onload =  function() {
	preparePage();
};

