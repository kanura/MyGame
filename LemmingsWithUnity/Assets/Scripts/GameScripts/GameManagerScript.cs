using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {
	public bool GameStart = false;
	public bool GameEnd = false;
	public bool GameClear = false;
	[SerializeField] GameObject DefaultSet;
	[SerializeField] GameObject GameOverTexts;
	[SerializeField] GameObject GameClearTexts;
	// Use this for initialization
	void Start () {
		GameStart = true;
		DefaultSet.SetActive(false);
		GameOverTexts.SetActive(false);
		GameClearTexts.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameStart) {
			DefaultSet.SetActive (true);
			GameOverTexts.SetActive (false);
		}
		if (GameClear) {
			DefaultSet.SetActive (false);
			GameClearTexts.SetActive (true);
		}
		else if (GameEnd) {
			DefaultSet.SetActive (false);
			GameOverTexts.SetActive (true);
		}

	}

	public void ResetAllFlags(){
		GameStart = false;
		GameEnd = false;
		GameClear = false;
	}

}
