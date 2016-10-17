var map;
var markerCausewayBay;

function initMap() {
  map = new google.maps.Map(document.getElementById('map'), {
    center: {lat: 22.283769, lng: 114.186176},
    zoom: 4
  });
}

function setMapMakers(){
	
	//0, 0 is the top left.Change it if the map is not start from top left
	var makerOriginX = 0;
	var makerOriginY = 0;
	
	//Setting the position of the Causeway Bay map maker
	var markerPositionCausewayBay = new google.maps.LatLng(22.283769, 114.186176);
	
	//Setting the icon to be used with the Causeway Bay map maker
	var makerIconCausewayBay = {
		url: 'image/hongkong.png',
		size: new google.maps.Size(140, 135),
		
		//The point on the image to measure the anchor from. 
		origin: new google.maps.Point(makerOriginX, makerOriginY),
		
		//Adjust the icon position
		anchor: new google.maps.Point(42, 133)
	};
	
	//Setting the shape to be used with map maker
	var markerShapeCausewayBay = {
		coord: [12,4,216,22,212,74,157,70,184,111,125,67,6,56],
		type: 'poly'
	};
	
	//Creating the Causeway Bay map marker
	markerCausewayBay = new google.maps.Marker({
		position: markerPositionCausewayBay, map: map, title: 'Hong Kong', 
		icon: makerIconCausewayBay, shape: markerShapeCausewayBay,
		
		//depth, It determines how elements are 'stacked' on top of each other, and hence how they overlap
		//the closer to the bottom of the screen a marker is, the higher its z-index should be.
		zIndex:107
	});
	
	google.maps.event.addListener(markerCausewayBay, 'click', function() {  
        popUp("popUpHongKong");
    });
}
function setMapStyle(){
    
    //initial the data
    var style_map = [
    {
        "featureType": "administrative",
        "stylers": [{ "visibility": "on" }]
    },
    {
        //point of interesting
        "featureType": "poi",
        "stylers": [{ "visibility": "off" }]
    },
    {
        "featureType": "transit",
        "stylers": [{ "visibility": "off" }]
    },
    {
        "featureType": "road",
        "stylers": [{ "visibility": "off" }]
    },
    {
        "featureType": "landscape",
        "stylers": [{ "color": "#FFE494" }]
    },
    {
        "featureType": "water",
        "stylers": [{ "visibility": "on" }, { "color": "#90C4EC" }]
    }
    ]
    
    //Pass the data to the style
    var styled_map = new google.maps.StyledMapType(style_map, {name: "Styled Map"});
    
    //Assign the style to map
    map.mapTypes.set('map_styles', styled_map);
    map.setMapTypeId('map_styles');
    }

window.onload =  function() {
	initMap();
	setMapMakers();
    setMapStyle();
};

//pop up windows
function toggle(div_id){
	var divID = document.getElementById(div_id);
	if(divID.style.display == 'none'){
		divID.style.display = 'block';
            console.log("block");
	}else{
		divID.style.display = 'none';
        divID.style.visibility = 'none';
        console.log("none");
	}
}
function popUp(windowName){
	toggle("blanket");
	toggle(windowName);
}


