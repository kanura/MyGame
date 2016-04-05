using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	// 生成したいPrefab
	[SerializeField]public GameObject[] Prefabs;
	// parameters
	private int num = 0;
	private float ChangeAngle = 15.0f;
	private int ChangeAngleCount = 0;
	// クリックした位置座標
	private Vector3 clickPosition;
	// 現在描画中のspriteRender
	[SerializeField] public SpriteRenderer MainSpriteRenderer;
	[SerializeField] public Sprite DefaultSprite;
	[SerializeField] public Sprite[] NextSprite;
	// GameObjects for ActButtonEvent
	[SerializeField] GameObject MagObject;//for 3
	[SerializeField] GameObject AllGroundObjects;//for 4
	// GameObjects of Manager
	[SerializeField] GameObject ParameterManager;

	// Use this for initialization
	void Start () {
		MagObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//temp part
		if(ChangeAngleCount>0) ChangeAngleByStep();
		if (Input.anyKeyDown && !Input.GetMouseButtonDown (0)) UpdateNum ();
		// マウス入力で左クリックをした瞬間
		if (Input.GetMouseButtonDown(0) && num != 0) {
			if (!ActButtonEvent (num)) {
				// ここでの注意点は座標の引数にVector2を渡すのではなく、Vector3を渡すことである。
				// Vector3でマウスがクリックした位置座標を取得する
				clickPosition = Input.mousePosition;
				// Z軸修正
				clickPosition.z = 10f;
				// オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
				// ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
				Instantiate (Prefabs [num], Camera.main.ScreenToWorldPoint (clickPosition), Prefabs [num].transform.rotation);
			}
			UpdateEnergy (num+1);
		}
	}

	// use for re-initialize 
	void reInit(){
		MagObject.SetActive (false);
	}

	void UpdateNum(){
		Debug.Log ("get key down = "+num);
		if (Input.GetKeyDown ("0")) num = 0;
		else if (Input.GetKeyDown ("1")) num = 1;
		else if (Input.GetKeyDown ("2")) num = 2;
		else if (Input.GetKeyDown ("3")) num = 3;
		else if (Input.GetKeyDown ("4")) num = 4;
		//else if (Input.GetKeyDown ("5")) num = 5;
		//else if (Input.GetKeyDown ("6")) num = 6;
		//else if (Input.GetKeyDown ("7")) num = 7;
		//else if (Input.GetKeyDown ("8")) num = 8;
		//else if (Input.GetKeyDown ("9")) num = 9;

		// update sprite
		MainSpriteRenderer.sprite = NextSprite[num];
	}

	public bool ActButtonEvent(int num){
		switch (num) {
		case 3:
			Debug.Log ("case" + num);
			ClickButton3 ();
			break;
		case 4:
			Debug.Log ("case" + num);	
			ChangeGravity ();
			break;
		default:
			Debug.Log ("default case" + num);
			reInit ();
			return false;
		}
		return true;
	}

	public void ChangeGravity(){
		ChangeAngleCount = 60;
		//AllGroundObjects.transform.Rotate(new Vector3 (0, 0, ChangeAngle));
		// 4秒かけて、y軸を260度回転
		//iTween.RotateTo(gameObject, iTween.Hash("y", 260, "time", 4.0f));

	}

	public void ChangeAngleByStep(){
		AllGroundObjects.transform.Rotate(new Vector3 (0, 0, ChangeAngle/60f));
		ChangeAngleCount--;
	}

	public void ClickButton3(){
		if (MagObject.active) Debug.Log ("mag.active");
		MagObject.SetActive (true);
	}

	public void UpdateEnergy(int num){
		ParameterManager.GetComponent<ParameterManager> ().AddEnergy (-num);
	}
}
