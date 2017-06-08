using UnityEngine;
using System.Collections;

public class blockcontroler : MonoBehaviour {

	int speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (3, 5);
	}
	
	// Update is called once per frame
	void Update () {

			transform.Translate (Vector2.left * speed * Time.deltaTime);
			if (transform.position.x < -3.62f) {
				Destroy (transform.gameObject);
			}



	}
}
