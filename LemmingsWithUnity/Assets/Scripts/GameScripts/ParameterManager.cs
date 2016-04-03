using UnityEngine;
using System.Collections;

public class ParameterManager : MonoBehaviour {
	[SerializeField] GameObject GameManager;
	public int Energy;

	// Use this for initialization
	void Start () {
		Energy = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (Energy <= 0) {
			GameManager.GetComponent<GameManagerScript> ().ResetAllFlags ();
			GameManager.GetComponent<GameManagerScript> ().GameEnd = true;
		}
	}

	public void AddEnergy(int num){
		Energy += num;
	}

	public void SetEnergy(int num){
		Energy = num;
	}

	public int GetEnergy(){
		return Energy;
	}
}
