using UnityEngine;
using System.Collections;
using System.Xml;

struct Geocode{
	public double lat;
	public double lng;
}

public class Merchant : Object {
	
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
	result += zipCode.ToString();
	result += " Lat: ";
	result += position.lat;
	result += ", Long: ";
	result += position.lng;
	
	return result;
}
