using UnityEngine;
using System.Collections;

public class ButtonEvent : MonoBehaviour {
	private int DefaultNum = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool ActButtonEvent(int num){
		switch (num) {
			case 1:
				Debug.Log ("case"+num);
				break;
			case 2:
				Debug.Log ("case"+num);			
				break;
			default:
				Debug.Log ("default case"+num);			
			return false;
		}
		return true;
	}
}
