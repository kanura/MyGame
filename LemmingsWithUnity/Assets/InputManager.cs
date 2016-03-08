using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	// 生成したいPrefab
	public GameObject[] Prefabs;
	public int num = 0;
	// クリックした位置座標
	private Vector3 clickPosition;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown && !Input.GetMouseButtonDown (0)) UpdateNum ();
		// マウス入力で左クリックをした瞬間
		if (Input.GetMouseButtonDown(0) && num != 0) {
			// ここでの注意点は座標の引数にVector2を渡すのではなく、Vector3を渡すことである。
			// Vector3でマウスがクリックした位置座標を取得する
			clickPosition = Input.mousePosition;
			// Z軸修正
			clickPosition.z = 10f;
			// オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
			// ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
			Instantiate(Prefabs[num], Camera.main.ScreenToWorldPoint(clickPosition), Prefabs[num].transform.rotation);
		}
	}

	void UpdateNum(){
		if (Input.GetKeyDown ("0")) num = 0;
		if (Input.GetKeyDown ("1")) num = 1;
		if (Input.GetKeyDown ("2")) num = 2;
	}
}
