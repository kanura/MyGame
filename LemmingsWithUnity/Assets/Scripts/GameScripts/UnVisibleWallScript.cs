using UnityEngine;
using System.Collections;

public class UnVisibleWallScript : MonoBehaviour {
	[SerializeField] GameObject GameManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			//GameManager.GetComponent<GameManagerScript> ().ResetAllFlags ();
			GameManager.GetComponent<GameManagerScript> ().GameEnd = true;
		}
	}
}
