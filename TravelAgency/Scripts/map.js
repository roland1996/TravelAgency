window.onload = function() {
    var mapOptions = {
        center: new google.maps.LatLng(52.96187505907603, 24.2138671875),
        zoom: 5,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), mapOptions);
 
    google.maps.event.addListener(map, 'click', function(e) {
       
        var location = e.latLng;
        var marker = new google.maps.Marker({
            position: location,
            map: map
        });
 
        google.maps.event.addListener(marker, "click", function(e) {
            var infoWindow = new google.maps.InfoWindow({
                content: 'Latitude: ' + location.lat() + '<br />Longitude: ' + location.lng()
            });
            infoWindow.open(map, marker);
        });
    });
};   