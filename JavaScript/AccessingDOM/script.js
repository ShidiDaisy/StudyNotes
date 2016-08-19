var mainTitle = document.getElementById("mainTitle");

console.log("This is an element of type: ", mainTitle.nodeType);
console.log("the Inner HTML is ", mainTitle.innerHTML);
console.log("Child nodes: ", mainTitle.childNodes.length);//how many child nodes I have

var myLinks = document.getElementsByTagName("a");
console.log("Links: ", myLinks.length);

//Changing DOM elements
var mainContent = document.getElementById("mainContent");
mainContent.setAttribute("align", "right");
//grab the information inside the html
var sidebar = document.getElementById("sidebar");
console.log(sidebar.innerHTML);

//add text content to DOM
//Create the elements
var newHeading = document.createElement("h1");
var newParagraph = document.createElement("p");
//add content
newHeading.innerHTML = "Did you know";
newParagraph.innerHTML = "California produces over 17 million gallons of wine each year!";
//attach them to the document
document.getElementById("trivia").appendChild(newHeading);
document.getElementById("trivia").appendChild(newParagraph);
