using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public Vector2 playerPosition;
	public bool alive = true; //State is the player is still alive
	Vector2 jumpForce = new Vector2(0,350); //Jump power of the player
	
	// Update is called once per frame
	void Update () {
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if(alive)
			{
				// If the player ask for a jump, update velocity
				if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
				{
					rigidbody2D.velocity = Vector2.zero;
					rigidbody2D.AddForce(jumpForce);
				}

				playerPosition = rigidbody2D.position;

				//If the player leave the screen, he's considered as dead
				if (screenPosition.y > Screen.height || screenPosition.y < 0)
				{
					Death ();
				}
			}
		else
		{
			transform.Rotate(0, 0, -3.0f);
			transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
			if(screenPosition.y < 0)
			{
				DestroyObject(gameObject);
			}
		}
	}

	// If the player hit any obstacle, he's dead
	void OnCollisionEnter2D(Collision2D other)
	{
		Death ();
	}

	void Death()
	{
		alive = false;
		DestroyObject(rigidbody2D);
	}
}
