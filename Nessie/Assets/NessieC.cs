using UnityEngine;
using System.Collections;
using System.Xml;

public class NessieC : MonoBehaviour {

	// Use this for initialization
	void Start() {
		
		//StartCoroutine(getStuff());
	}
	
	IEnumerator getStuff() {
		//string url = "api.reimaginebanking.com/enterprise/accounts/56c66be6a73e492741507b2b?key=aa71fb9ed959b8325c48ad5b5892b755";
		string url = "thebrandmans.net/joshtest/test.txt";
		WWW www = new WWW(url);
		yield return www;
		
		string raw = www.text.Substring(17,www.text.Length-23);
		
		Debug.Log(raw);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
