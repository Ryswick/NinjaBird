using UnityEngine;
using System.Collections;

public class PressToPlay : MonoBehaviour {

	public GameObject obstacleSpawner;
	GameObject player;
	GameObject score;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player").gameObject;
		score = GameObject.Find ("Score").gameObject;

		player.rigidbody2D.gravityScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			player.rigidbody2D.gravityScale = 2.5f;
			Instantiate(obstacleSpawner);
			score.guiText.color = new Color(score.guiText.color.r, score.guiText.color.g, score.guiText.color.b, 1f);
			DestroyObject(gameObject);
		}
	}
}
