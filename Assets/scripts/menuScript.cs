using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class menuScript : MonoBehaviour {

	// Use this for initialization
	int i=0;
	public Text text1, text2;




	public void GetThatLevel(string levelname){
		Application.LoadLevel (levelname);

	}

	public void colorChanger(){
		Color[] col = { Color.blue, Color.green, Color.red,Color.white, Color.gray, Color.cyan };
		text1.color = col [i];
		text2.color = col [i];
		i++;
		if (i >= col.Length) {

			i = 0;
		}

	}

	public void Start(){
		InvokeRepeating ("colorChanger", 2.0f, 2.0f);
	}

}
