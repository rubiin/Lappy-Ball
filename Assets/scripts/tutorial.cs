using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {

	public GameObject canvasMain,player;


	// Use this for initialization
	void Start () {
		
		this.gameObject.SetActive (true);
		canvasMain.SetActive (false);
		player.SetActive (false);
	}
	
	// Update is called once per frame



	public void activateMain(){

		this.gameObject.SetActive (false);
		canvasMain.SetActive (true);
		player.SetActive (true);
	}

}
