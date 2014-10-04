using UnityEngine;
using System.Collections;

public class ObstacleGeneration : MonoBehaviour {

	public GameObject obstacle;
	Player player;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 1.2f);
		player = GameObject.Find("Player").gameObject.GetComponent<Player>();
	}

	void Update() {
		if(!player.alive)
			DestroyObject(gameObject);
	}
	
	// Update is called once per frame
	void CreateObstacle () {
		Instantiate(obstacle);
	}
}
