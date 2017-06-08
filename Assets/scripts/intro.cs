using UnityEngine;
using System.Collections;

public class intro : MonoBehaviour {

	float timerCount=0;

	// Use this for initialization
	void Start () {
		timerCount = Time.time + 5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerCount <= Time.time) {

			Application.LoadLevel ("menu");
		}
	}
}
