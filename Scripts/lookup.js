$("#Search").typeahead({
    source: function (query, process) {
        var countries = [];
        map = {};

        // This is going to make an HTTP post request to the controller
        return $.post('/Client/SearchLookup', { query: query }, function (data) {

            // Loop through and push to the array
            $.each(data, function (i, country) {
                map[country.Name] = country;
                countries.push(country.Name);
            });

            // Process the details
            process(countries);
        });
    },
    updater: function (item) {
        var selectedShortCode = map[item].ShortCode;

        // Set the text to our selected id
        $("#details").text("Selected : " + selectedShortCode);
        return item;
    }
});