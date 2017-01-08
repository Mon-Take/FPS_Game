using UnityEngine;
using System.Collections;

public class MovingEnemyScript : MonoBehaviour {

    NavMeshAgent agent; //NavMeshのエージェント
	GameObject player; //プレイヤー

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> (); 
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		// 目的地をプレイヤーに設定する。
		agent.SetDestination(player.transform.position);
	}
}
