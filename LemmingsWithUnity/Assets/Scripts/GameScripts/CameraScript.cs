using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public GameObject target;
	public Vector3 offset = new Vector3(0,0,-10);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		transform.position = target.transform.position+offset;
	}
}
