using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
	[SerializeField] GameObject GameManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("on trigger enter 2D in Goal script");
		GameManager.GetComponent<GameManagerScript> ().ResetAllFlags ();
		GameManager.GetComponent<GameManagerScript> ().GameClear = true;
	}
}
