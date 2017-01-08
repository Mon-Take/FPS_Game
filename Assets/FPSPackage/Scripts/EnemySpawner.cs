using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy; //敵のオブジェクト
	public float interval = 3; //何秒に一回敵を発生させるか
	float timer = 0; //タイマー

	void Update () {
		timer -= Time.deltaTime; //タイマーを減らす
		if (timer < 0) { //タイマーがゼロより小さくなったら
			Spawn (); // Spawnメソッドを呼ぶ
			timer = interval; // タイマーをリセットする
		}
	}
	// 敵を生成するメソッド
	void Spawn(){
		Instantiate (enemy, transform.position, transform.rotation);
	}
}
