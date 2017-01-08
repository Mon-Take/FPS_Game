using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour {

	void Update(){
		// スペースキーを押したら
		if (Input.GetKey (KeyCode.Space)) {
			Retry (); //リトライ
		}
	}

	// リトライメソッド
	public void Retry(){
		if (ScoreManager.instance) {
			// 敵を倒した回数をゼロにリセットする 
			ScoreManager.instance.enemyCount = 0;
		}
		// メインシーンに移動する
		SceneManager.LoadScene("Main");
	}
}
