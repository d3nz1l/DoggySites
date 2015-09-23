
function BingMap(mapContainer) {
    
    this.key = "AsRE0Uz6El9BmeU5ky-5UmEXw4nkevMoksPzw50FrsVD-lYIOjFEpxl_wnmrPjZV";
    this.container = mapContainer;

    this.options = this.createOptions();
    
    this.getMap();

    var self = this;

    var setLocation = function() {
        self.setLocation();
    }

    // Load modules
    Microsoft.Maps.loadModule('Microsoft.Maps.Search', { callback: setLocation });
}

BingMap.prototype.createOptions = function () {

    var options = {
        credentials: this.key,
        enableSearchLogo: this.getOption('enableSearchLogo'),
        mapTypeid: Microsoft.Maps.MapTypeId.aerial
    }

    return options;
}

BingMap.prototype.getOption = function(option) {

    var data = this.container.data(option);

    var def = this.deafaultOptions[option];

    if (data === undefined) {
        return def;
    }

    return data;
}

BingMap.prototype.getMapType = function() {

    var optionValue = this.getOption('mapType');
    var mapType = Microsoft.Maps.MapTypeId.aerial;

    switch (optionValue) {
        case 'aerial':

            mapType = Microsoft.Maps.MapTypeId.aerial;
            break;

        case 'os':

            mapType = Microsoft.Maps.MapTypeId.ordinanceSurvey;
            break;
    }

    return mapType;
}

BingMap.prototype.setLocation = function () {

    var latitude = this.getOption('latitude');
    var longitude = this.getOption('longitude');
    var zoom = this.getOption('zoom');

    if (latitude === undefined || longitude === undefined) {

        this.searchLocation('Bristol, UK', zoom);
        return;
    }
    
    var location = new Microsoft.Maps.Location(latitude, longitude);

    this.mapLocation(location, zoom);
}

BingMap.prototype.searchLocation = function (address, zoom) {

    this.createSearchManager();

    var data = {
        zoom: zoom ? zoom : this.getOption('zoom'),
        self: this
    };

    var onGeocodeFailed = function() {
        // Just show bristol
        var location = new Microsoft.Maps.Location('51.4115062667691', '-2.76832604408264');

        this.mapLocation(location, 5);
    }

    var onGeocodeSuccess = function(results, userData) {
        if (!results) {
            return;
        }

        userData.self.clearEntities();
        var topResult = results.results && results.results[0];

        if (topResult) {

            userData.self.mapLocation(topResult.location, userData.zoom);
            return;
        }
    }

    var request =
    {
        where: address,
        count: 5,
        bounds: this.map.getBounds(),
        callback: onGeocodeSuccess,
        errorCallback: onGeocodeFailed,
        userData: data
    };

    this.searchManager.geocode(request);
}

BingMap.prototype.mapLocation = function(location, zoom) {
    
    this.map.setView({
        zoom: zoom,
        center: location
    });

    this.addPushpin(location);
}

BingMap.prototype.addPushpin = function (location, pushpinOptions) {
    
    if (!this.getOption('pushpin')) {
        return;
    }

    this.clearEntities();

    var icon = this.getOption('pushpinIcon');

    if (icon && !pushpinOptions) {
        var img = new Image();
        var self = this;
        img.onload = function() {
            var options = { icon: icon, width: this.width, height: this.height };
            self.addPushpin(location, options);
        }
        img.src = icon;
        return;
    }

    var pushpin = new Microsoft.Maps.Pushpin(location, pushpinOptions);
    this.map.entities.push(pushpin);
}

BingMap.prototype.clearEntities = function () {

    if (this.mapLocation.entities) {

        this.mapLocation.entities.clear();
    }
}

BingMap.prototype.createSearchManager = function () {

    if (!Microsoft.Maps.Search) {
        setTimeout(this.createSearchManager, 100);
        return;
    }

    if (!this.searchManager) {
        this.map.addComponent('searchManager', new Microsoft.Maps.Search.SearchManager(this.map));
        this.searchManager = this.map.getComponent('searchManager');
    }
}

BingMap.prototype.getMap = function() {

    this.map = new Microsoft.Maps.Map(this.container.get(0), this.options);
}

BingMap.prototype.deafaultOptions = {
    credentials: '',
    enableSearchLogo: false,
    mapTypeid: Microsoft.Maps.MapTypeId.aerial,
    zoom: 7,
    pushpin: true
}

