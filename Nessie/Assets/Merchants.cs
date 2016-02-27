using UnityEngine;
using System.Collections;
using System.Xml;

struct Geocode{
	public double lat;
	public double lng;
}
struct Address{
	public string city;
	public string state;
	public string streetName;
	public string streetNumber;
	public int zipCode;
}

public class Merchant : Object {
	
	public Merchant();
	public Merchant(string[] input);
	public string ToString();
	
	public string name{ get; private set; }
	public Address address{ get; private set; }
	public Geocode position{ get; private set; }
}
Merchant::Merchant()
{
	name = "";
	id = "";
	address.city = "";
	address.state = "";
	address.streetName = "";
	address.streetNumber = "";
	address.zipCode = 0;
	position.lat = 0.0;
	position.lng = 0.0;
}
Merchant::Merchant(string[] input)
{
	if (input.Length == 9){	
		name = input[8];
		id = input[0];
		address.city = input[1];
		address.state = input[2];
		address.streetName = input[3];
		address.streetNumber = input[4];
		address.zipCode = Int32.TryParse(input[5]);
		position.lat = float.TryParse(input[6]);
		position.lng = float.TryParse(input[7]);
	}
	else
	{
		System.Console.WriteLine("DON'T F***ING DO THAT. Also, you should probably pass an array with 9 elements");
	}
}
string Merchant::ToString(){
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
