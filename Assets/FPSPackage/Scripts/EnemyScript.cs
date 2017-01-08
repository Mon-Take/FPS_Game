using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int enemyHP = 3; // 敵の体力
	public GameObject Bomb; // 爆発のオブジェクト

	// Playerにダメージを与えられた時
	void Damage(){
		enemyHP--; //体力を1減らす。
		// 体力がゼロになったら
		if (enemyHP == 0) {
			if (Bomb) {
				// 爆発を起こす
				Instantiate (Bomb, transform.position, transform.rotation);
			}
			// 敵を倒した数を1増やす
			ScoreManager.instance.enemyCount++;
			Destroy (this.gameObject); //自分をしょうめつさせる

		}
	}
	// 物にさわった時に呼ばれる
	void OnTriggerEnter(Collider col){
		// もしPlayerにさわったら
		if (col.gameObject.tag == "Player") {
			Debug.Log ("ds");
			col.SendMessage ("Damage"); //ダメージを与えて
		}
		// 自分は消える
		Destroy (this.gameObject);
	}
}
