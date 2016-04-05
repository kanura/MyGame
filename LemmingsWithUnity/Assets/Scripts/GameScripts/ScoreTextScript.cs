using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {
	[SerializeField] GameObject ParamManager;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		TextMesh tm =(TextMesh)this.GetComponent (typeof(TextMesh));
		tm.text = "Score : "+string.Format("{0}",ParamManager.GetComponent<ParameterManager> ().GetEnergy ());
	}
}
