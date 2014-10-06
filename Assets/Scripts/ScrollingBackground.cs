using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

	float scrollingSpeed = 1.5f;

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);

		if(transform.position.x < -8.8f)
			transform.position = new Vector3(15.2f, 0f, 1f);
	}
}
