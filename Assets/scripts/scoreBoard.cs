using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour {


	public Text dark,normal,doub,high;
	int i=0;

	// Use this for initialization
	void Start () {
		doub.text= PlayerPrefs.GetInt ("highscoreOfDoubleTrouble",0).ToString();
		dark.text= PlayerPrefs.GetInt ("highscoreOfDark",0).ToString();
		normal.text= PlayerPrefs.GetInt ("highscore",0).ToString();
		InvokeRepeating ("colorChanger", 2.0f, 2.0f);
	}


	public void colorChanger(){
		Color[] col = { Color.blue, Color.green, Color.red,Color.white, Color.gray, Color.cyan };
		high.color = col [i];

		i++;
		if (i >= col.Length) {

			i = 0;
		}

	}


	public void getToMenu(){
		Application.LoadLevel ("menu");
	}

}
