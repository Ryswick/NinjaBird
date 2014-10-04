using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		//og = GameObject.Find("ObstacleSpawn").gameObject.GetComponent<ObstacleGeneration>();
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.guiText.text = og.score.ToString();
		gameObject.guiText.text = score.ToString();
	}
}
