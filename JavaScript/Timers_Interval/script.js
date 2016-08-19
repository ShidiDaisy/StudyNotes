// Two methods for timers - setTimeout and SetInterval (single / repeating)
//call a function after n seconds, or call a function every n seconds
function simpleMessage() {
	alert("This is just an alert box");
}

// settimeout is in ms
//1. call function simpleMessage after 5 seconds
setTimeout(simpleMessage,5000);
//setTimeout(function I want to called, interval)
var myImage = document.getElementById("mainImage");

var imageArray = ["_images/overlook.jpg","_images/winery_sign.jpg","_images/lunch.jpg",
				  "_images/bigSur.jpg","_images/flag_photo.jpg","_images/mission_look.jpg"];
var imageIndex = 0;

function changeImage() {
	myImage.setAttribute("src",imageArray[imageIndex]);
	imageIndex++;
	if (imageIndex >= imageArray.length) {
		imageIndex = 0;
	}
}

// setInterval is also in ms
//2. call a function after 5 seconds
/*
setInterval(changeImage,5000);
*/

//3. the image changing every 5s, stop changing anymore after user clicked.
var intervalHandle = setInterval(changeImage,5000);

myImage.onclick=function(){
	clearInterval(intervalHandle);
	//clearTimeout
}
