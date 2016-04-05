using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	public string nextSceneName = "StageSelectScene";

	public void ReturnToStageSelectScene(){
		Application.LoadLevel (nextSceneName);
	}
}
