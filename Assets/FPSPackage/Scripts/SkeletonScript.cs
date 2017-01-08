using UnityEngine;
using System.Collections;

public class SkeletonScript : MonoBehaviour {

	public int enemyHP = 30;
	public GameObject Bomb;

	// Use this for initialization
	void Damage () {
		enemyHP--;
		if (enemyHP == 0) {
			if (Bomb) {
				Instantiate (Bomb, transform.position, transform.rotation);
			}
			ScoreManager.instance.enemyCount++;
			Destroy (this.gameObject);
		}
	}
