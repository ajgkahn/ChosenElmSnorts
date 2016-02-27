using UnityEngine;
using System.Collections;
using System.Xml;

struct Geocode{
	public double lat;
	public double lng;
}

public class Merchant : Object {
	
	public Merchant();
	public Merchant(string[] input);
	public string ToString();
	
	public string name{ get; set; }
	public string id{ get; set; }
	public string city{ get; set; }
	public string state{ get; set; }
	public string streetName{ get; set; }
	public string streetNumber{ get; set; }
	public int zipCode{ get; set; }
	Geocode position{ get; set; }
}
Merchant::Merchant()
{
	name = "";
	id = "";
	city = "";
	state = "";
	streetName = "";
	streetNumber = "";
	zipCode = 0;
	position.lat = 0.0;
	position.lng = 0.0;
}
Merchant::Merchant(string[] input)
{
	if (input.Length == 9){	
		name = input[8];
		id = input[0];
		city = input[1];
		state = input[2];
		streetName = input[3];
		streetNumber = input[4];
		zipCode = Int32.TryParse(input[5]);
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
	result += streetNumber;
	result += " ";
	result += streetName;
	result += ", ";
	result += zipCode;
	result += " Lat: ";
	result += position.lat;
	result += ", Long: ";
	result += position.lng;
	
	return result;
}
