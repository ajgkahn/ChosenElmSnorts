$(document).ready(function() {
    $.ajax({
        url: "http://api.reimaginebanking.com/enterprise/merchants?key=aa71fb9ed959b8325c48ad5b5892b755"
    }).then(function(data) {
       /*$('.merchant-_id').append(data._id);
	   
	   $('.merchant-address').append(data.address);
	   $('.merchant-address-city').append(data.address.city);
	   $('.merchant-address-state').append(data.address.state);
	   $('.merchant-address-streetname').append(data.address["street name"]);
	   $('.merchant-address-streetnumber').append(data.address["street number"]);
	   $('.merchant-address-zip').append(data.address.zip);

	   $('.merchant-geocode').append(data.geocode);
	   $('.merchant-geocode-lat').append(data.geocode.lat);
	   $('.merchant-geocode-lng').append(data.geocode.lng);
	   
       $('.merchant-name').append(data.name);*/
	   
	   /*var names = '';
	   for(var i=0, i<data.length; i+=1) {
	     var merchant = data.results[i];
	     names = names.concat(merchant.name, "<br>");
	   }
	   $('.merchant_names').append(names);*/
	   
	   var names = '';
	   names = names.concat(data.results[0].name, "<br>");
	   names = names.concat(data.results[1].name, "<br>");
	   names = names.concat(data.results[2].name, "<br>");
	   names = names.concat(data.results[3].name, "<br>");
	   $('.merchant-names').append(names);
    });
});