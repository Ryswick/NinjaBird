using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomLine : MonoBehaviour {

	List<string> lines;

	// Use this for initialization
	void Start () {
		int randomValue; 

		lines = new List<string>();
		lines.Add("Mom was calling for dinner anyway.");
		lines.Add("You murdered her !");
		lines.Add("Now you can fly in hell.");
		lines.Add ("YATTA !");
		lines.Add ("I'm not responsible of this.");
		lines.Add ("Trust me, you're not a ninja.");
		lines.Add ("Obstacle : 1 / Ninja : 0");

		randomValue = (int)(Random.value * (lines.Count - 0.01));

		gameObject.guiText.text = lines[randomValue];
	}
}
