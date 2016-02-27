using UnityEngine;
using System.Collections;

public class NessieC : MonoBehaviour {

	// Use this for initialization
	void Start() {
		StartCoroutine(getStuff());
	}
	
	IEnumerator getStuff() {
		string test = "apple";
		Debug.Log(test);
		
		string url = "api.reimaginebanking.com/enterprise/accounts?key=aa71fb9ed959b8325c48ad5b5892b755";
		WWW www = new WWW(url);
		yield return www;
		Debug.Log(www.text);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
