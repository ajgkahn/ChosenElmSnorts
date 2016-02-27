using UnityEngine;
using System.Collections;
//using System.Xml;

public struct Geocode{
	public string lat;
	public string lng;
}
public struct Address{
	public string city;
	public string state;
	public string streetName;
	public string streetNumber;
	public string zipCode;
}

public class Merchant : Object {
	
	public string id{ get; private set; }
	public string name{ get; private set; }
	public Address address{ get; set; }
	public Geocode position{ get; set; }

    public Merchant() {
        name = "";
        id = "";
        address = new Address
        {
            city = "",
            state = "",
            streetName = "",
            streetNumber = "",
            zipCode = ""
        };
        position = new Geocode
        {
            lat = "",
            lng = ""
        };
	
}
	public Merchant(string[] input){
	if (input.Length == 9){	
		name = input[8];
		id = input[0];
            address = new Address
            {
                city = input[1],
                state = input[2],
                streetName = input[3],
                streetNumber = input[4],
                zipCode = input[5]
            };
            position = new Geocode
            {
                lat = input[6],
                lng = input[7]
            };
		
	}
	else
	{
		System.Console.WriteLine("DON'T F***ING DO THAT. Also, you should probably pass an array with 9 elements");
	}
}
	public Merchant(string _id, Address adrs, Geocode loc, string nm){
	name = nm;
	id = _id;
	address = adrs;
	position = loc; 
}
	public string ToString(){
	string result = "";
	result += "Name: ";
	result += name;
	result += ", ID: ";
	result += id;
	result += ", ";
	result += address.streetNumber;
	result += " ";
	result += address.streetName;
	result += ", ";
	result += address.city;
	result += ", ";
	result += address.state;
	result += " ";
	result += address.zipCode;
	result += " Lat: ";
	result += position.lat;
	result += ", Long: ";
	result += position.lng;
	
	return result;
}
	
}