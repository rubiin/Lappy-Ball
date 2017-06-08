using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public float spawndelay=.3f;
	public GameObject block;
	public float timetonextspawn=0;
	public Transform[] spawnpoints;


	// Update is called once per frame
	void Update () {
	
		if (timetonextspawn <= Time.time) {

			spawncar ();
			timetonextspawn = Time.time + spawndelay;
		}
	}





	void spawncar(){
		int randomnum = Random.Range (0, spawnpoints.Length);
		Transform point = spawnpoints [randomnum];

		Instantiate (block,point.position,point.rotation);

	}


}
