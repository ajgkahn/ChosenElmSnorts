using UnityEngine;
using System.Collections;
//using System.Xml;

struct Geocode{
	public string lat;
	public string lng;
}
struct Address{
	public string city;
	public string state;
	public string streetName;
	public string streetNumber;
	public string zipCode;
}

public class Merchant : Object {
	
	public Merchant(){
	name = "";
	id = "";
	address.city = "";
	address.state = "";
	address.streetName = "";
	address.streetNumber = "";
	address.zipCode = "";
	position.lat = 0.0;
	position.lng = 0.0;
}
	public Merchant(string[] input){
	if (input.Length == 9){	
		name = input[8];
		id = input[0];
		address.city = input[1];
		address.state = input[2];
		address.streetName = input[3];
		address.streetNumber = input[4];
		address.zipCode = input[5];
		position.lat = input[6];
		position.lng = input[7];
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
	string result;
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
	
	public string name{ get; private set; }
	public Address address{ get; private set; }
	public Geocode position{ get; private set; }
}