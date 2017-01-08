using UnityEngine;
using System.Collections;

public class Cursorlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// マウスカーソルを画面内にロックする。
		Screen.lockCursor = true;
//		Cursor.lockState = CursorLockMode.Locked;
		// マウスカーソルを消去する
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// ダメージを与えられた時、カメラを揺らす
	void Damage(){
		transform.FindChild ("MainCamera").SendMessage ("Shake");
	}
}
