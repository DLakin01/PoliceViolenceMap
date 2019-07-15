window.AddMarkersToMap = function(map, incidents) {
    
    var markers = incidents.map(function (incident) {
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(parseFloat(incident.latitude), parseFloat(incident.longitude))
        });

        var contentString = "<div id='content'>" +
            "<h3>" + incident.victimSName + "</h3>" +
            "<div id='bodyContent'>" +
            "<p>" + incident.briefDescriptionOfCircumstances + "</p>" +
            "<br>" +
            "<span><strong>Outcome: " + incident.criminalCharges + " | " +
            "<a href=" + incident.linkToNewsArticleOrPhotoOfOfficialDocument + " target='_blank'>More Info</a></span>";

        var infoWindow = new google.maps.InfoWindow({ content: contentString });
        marker.addListener("click", function () {
            infoWindow.open(map, marker);
        });

        return marker;
    });

    // Add marker clusterer
    var markerCluster = new MarkerClusterer(map, markers, { imagePath: "images/m" });
}