using UnityEngine;
using System.Collections;
using System.Xml;
using System;
using System.Collections.Generic;

public class NessieC : MonoBehaviour {

	// Use this for initialization
	void Start() {
		
		StartCoroutine(getStuff());
	}
	
	IEnumerator getStuff() {
		//string url = "api.reimaginebanking.com/enterprise/accounts/56c66be6a73e492741507b2b?key=aa71fb9ed959b8325c48ad5b5892b755";
		string url = "thebrandmans.net/joshtest/test.txt";
		WWW www = new WWW(url);
		yield return www;
		
		string raw = www.text.Substring(17,www.text.Length-23);
        string[] lines = raw.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
        List <Merchant> merchants= new List<Merchant>(); 
      
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Substring(0, lines[i].Length - 2);
            string id = line.Substring(line.IndexOf(":") + 3);
            i += 2;
            line = lines[i].Substring(0, lines[i].Length - 2);
            string city = line.Substring(line.IndexOf(":") + 3);
            i++;
            line = lines[i].Substring(0, lines[i].Length - 2);
            string state = line.Substring(line.IndexOf(":") + 3);
            i++;
            line = lines[i].Substring(0, lines[i].Length - 2);
            string sName = line.Substring(line.IndexOf(":") + 3);
            i++;
            line = lines[i].Substring(0, lines[i].Length - 2);
            string sNum = line.Substring(line.IndexOf(":") + 3);
            i++;
            line = lines[i].Substring(0, lines[i].Length - 1);
            string zip = line.Substring(line.IndexOf(":") + 3);
            Address newAddr;
            newAddr.city = city;
            newAddr.state = state;
            newAddr.streetName = sName;
            newAddr.streetNumber = sNum;
            newAddr.zipCode = zip;
            i += 3;
            line = lines[i].Substring(0, lines[i].Length - 1);
            string lat = line.Substring(line.IndexOf(":") + 2);
            i++;
            line = lines[i].Substring(0, lines[i].Length);
            string lng = line.Substring(line.IndexOf(":") + 2);
            Geocode code;
            code.lat = lat;
            code.lng = lng;
            i += 2;
            line = lines[i].Substring(0, lines[i].Length - 1);
            string name = line.Substring(line.IndexOf(":") + 3);
            i += 2;

            Merchant merch = new Merchant(id, newAddr, code, name);
            merchants.Add(merch);
            Debug.Log(merch.ToString());
            
        }
		
		//Debug.Log(raw);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
