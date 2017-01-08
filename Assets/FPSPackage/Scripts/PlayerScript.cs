using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript: MonoBehaviour {

	public int playerHP = 3;
	public Text HPLabel;


	// ゲームの1フレームごとに呼ばれるメソッド
	void Update () {
		
		HPLabel.text = "PlayerHP:" + playerHP.ToString ();

	}

	// ダメージを与えられた時に行いたい命令を書く
	void Damage(){
		playerHP--;
		if (playerHP <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}
}

