using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	Vector2 velocity = new Vector2(-4, 0);
	float range = 6;
	Player player;
	Score score;
	bool dodged = false; // Whether or not the player dodged the obstacle

	void Start() {
		rigidbody2D.velocity = velocity;
		rigidbody2D.position = new Vector2(rigidbody2D.position.x, rigidbody2D.position.y - range * Random.value);
		score = GameObject.Find("Score").gameObject.GetComponent<Score>();
		player = GameObject.Find("Player").gameObject.GetComponent<Player>();
	}

	// Update is called once per frame
	void Update () {
		if(player.alive)
		{
			// If the obstacle is not shown on the camera, it's destroyed
			if(rigidbody2D.position.x < -23)
				DestroyObject(gameObject);

			// We make the obstacle move to the left
			rigidbody2D.velocity = velocity;

			// If the player dodged the obstacle, the score is updated
			if(player.playerPosition.x > rigidbody2D.position.x && !dodged)
			{
				dodged = true;
				score.score++;
				audio.Play();
			}
		}
		// If the player is dead, we destroy the rigidbody of the obstacle
		else
		{
			if(rigidbody2D)
				DestroyObject(rigidbody2D);
		}
	}
}
