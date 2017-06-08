using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelSelect : MonoBehaviour {

	public Transform LevelScreen;
	public Sprite[] spritecoll;
	string[] levelname={"normal","dark","doubletrouble"};
	int i=0;
	string levelToload="normal";
	public Text loadedLevel;




	public void ButtonNext(){


		if (i < spritecoll.Length-1) {
			LevelScreen.GetComponent<SpriteRenderer> ().sprite = spritecoll [++i];
			levelToload = levelname [i];
			loadedLevel.text = "<<"+levelToload + ">>";
		} else {

			i = spritecoll.Length-1;
		}
			

	}

	public void ButtonPrevious(){
		if (i > 0) {
			LevelScreen.GetComponent<SpriteRenderer> ().sprite = spritecoll [--i];
			levelToload = levelname [i];
			loadedLevel.text = "<<"+levelToload + ">>";
		} else {

			i = 0;
		}

	}

	public void ButtonPlay(){

	//	PlayerPrefs.DeleteAll ();
		Application.LoadLevel (levelToload);

	}

	public void Home(){

		Application.LoadLevel ("menu");


	}

}
