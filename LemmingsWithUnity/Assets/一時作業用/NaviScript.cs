using UnityEngine;
using System.Collections;

public class NaviScript : MonoBehaviour {
	[SerializeField] GameObject Player;
	[SerializeField] GameObject Goal;

	// Use this for initialization
	void Start () {
	
	}

	// PlayerからGoalへの角度を求める
	// @return 2点の角度(Degree)
	void Update () {
		float dx = Goal.transform.position.x - this.transform.position.x;
		float dy = Goal.transform.position.y - this.transform.position.y;
		float rad = Mathf.Atan2(dy, dx);
		Debug.Log(rad * Mathf.Rad2Deg);
		this.transform.Rotate (0,0,rad * Mathf.Rad2Deg);
		//this.transform.rotation = new Quaternion(0,0,270f+rad * Mathf.Rad2Deg,1);
	}
}
