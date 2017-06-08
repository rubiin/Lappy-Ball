using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player : MonoBehaviour {

	public Text score,highscore;
	public int speed,savedspeed;
	int i=1,scorePoint=0,invincibility=0,pointDeductions=0;
	public GameObject particleNew,particleWall;
	float countDown;

	Vector2 spawn;
	public AudioClip checkpoint,pop;
	AudioSource sounD;
	SpriteRenderer ren;
	string highScoreOfLevel="";






	// Use this for initialization
	void Start () {


		ren = GetComponent<SpriteRenderer> ();
		//timerstart ();
		sounD=GetComponent<AudioSource>();

		savedspeed = speed;
		spawn = transform.position;
		score.text = "" + scorePoint;

		switch (Application.loadedLevelName) {


		case "normal":
			highScoreOfLevel = "highscore";
			pointDeductions = 5;
			break;
		case "dark":
			highScoreOfLevel = "highscoreOfDark";
			pointDeductions = 3;
			break;
		case "doubletrouble":
			highScoreOfLevel = "highscoreOfDoubleTrouble";
			pointDeductions = 2;
			break;


		}

		highscore.text = PlayerPrefs.GetInt (highScoreOfLevel,0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (i > 0) {
	
			transform.Translate (Vector2.up * speed * Time.deltaTime);
		} else {
			transform.Translate (Vector2.down * speed * Time.deltaTime);

		}
		if (Input.GetMouseButtonDown(0) ){

			Debug.Log ("button detect");
			speed=0;

		}
		if (Input.GetMouseButtonUp(0) ){


			speed=savedspeed;

		}

		if (countDown <= Time.time) {

			invincibility = 0;
			ren.color=new Color(1f,1f,1f,1f);

		}


	}

	void timerstart(){
		countDown = 0;
		countDown = Time.time + 15f;

	}



	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "boundary1") {
			sounD.clip=checkpoint;
			sounD.Play ();
			i = i * -1;
			scorePoint += 1;
			score.text = "" + scorePoint;
			Vector2 red = coll.transform.position;
			red.x = red.x - 2;
			Instantiate (particleWall,red, coll.transform.rotation);

			if (scorePoint > PlayerPrefs.GetInt (highScoreOfLevel,0)) {
				PlayerPrefs.SetInt (highScoreOfLevel, scorePoint);
				highscore.text = scorePoint.ToString();


			}
		}

		if(coll.gameObject.tag == "block" && invincibility==0) {

			sounD.clip=pop;
			sounD.Play ();
			if (scorePoint >= pointDeductions) {
				scorePoint -= pointDeductions;
				score.text = "" + scorePoint;
			}
			Instantiate (particleNew,transform.position, transform.rotation);

			transform.position = spawn;
		
		}

		if (coll.gameObject.tag == "cloak") {

			// doesnt get affected even if hit
			ren.color=new Color(12f,12f,12f);
			coll.gameObject.SetActive (false);
			invincibility=1;
			timerstart ();

		}

		if (coll.gameObject.tag == "multiplier") {

			// doesnt get affected even if hit

		}


	}






}
