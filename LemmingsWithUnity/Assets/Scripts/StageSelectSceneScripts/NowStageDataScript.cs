using UnityEngine;
using System.Collections;

public class NowStageDataScript : MonoBehaviour {
	[SerializeField]public TextMesh NowStageName;
	private TextMesh NowStageData;
	public string[] StageName = { "DEBUG-STAGE","FOREST","MACHI"};
	public string[] Difficulty = {"Free","Easy","Normal"};
	public string[] Energy = { "None","100","100"};
	public string[] Connectable = { "Connectable","Disconnectable"};
	// Use this for initialization
	void Start () {
		NowStageData = (TextMesh)this.GetComponent (typeof(TextMesh));
		NowStageData.text = "No data...";
	}
	
	// Update is called once per frame
	void Update () {
		SetStageData ();
	}

	public void SetStageData(){
		int count = 0;
		foreach(string str in StageName){
			if (str.Equals (NowStageName.text)) {
				NowStageData = (TextMesh)this.GetComponent (typeof(TextMesh));
				NowStageData.text = 
					"Difficulty : "+Difficulty [count] + "\n" + 
					"Energy : "+Energy [count] + "\n" + 
					"Connect : "+Connectable [0];
				break;
			} else {
				NowStageData = (TextMesh)this.GetComponent (typeof(TextMesh));
				NowStageData.text = "No data...";
			}
			count++;
		}
	}
}
