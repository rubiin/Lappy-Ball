using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class settinsScript : MonoBehaviour {

	public Slider soundSlider;

	float volumeLevel;

	// Use this for initialization
	void Start () {
		volumeLevel=PlayerPrefs.GetFloat("gameVolume",1.0f);
		GetComponent<AudioSource> ().volume = volumeLevel;
		soundSlider.value=GetComponent<AudioSource> ().volume;
	}
	



	public void soundSliderChane(float f){

		Debug.Log ("slider val  "+f);
		PlayerPrefs.SetFloat ("gameVolume", f);
		GetComponent<AudioSource> ().volume = f;

	}


	public void Home(){

		Application.LoadLevel ("menu");


	}

}
