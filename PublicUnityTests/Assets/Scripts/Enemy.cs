using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	[SerializeField]
	EnemyData data;

	// Use this for initialization
	void Awake () {
		Debug.Log ("life is " + data.life);
	}
}
