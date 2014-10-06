using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	GameObject score;
	GameObject gameOver;
	GameObject randomLine;
	GameObject endScore;
	GameObject tryAgain;
	GameObject yes;
	GameObject no;

	float endTimeGameOver;
	float endTimeScore;
	float endTimeRandomLine;
	float endTimeOptions;

	bool isGameOverOnScreen = false;
	bool isScoreOnScreen = false;
	bool isRandomLineOnScreen = false;
	public bool areOptionsOnScreen = false;
	bool askedForEnd = false; // Whether or not the player asked to show all the game over screen

	// Use this for initialization
	void Start () {
		score = GameObject.Find("Score").gameObject;
		gameOver = GameObject.Find("GameOver").gameObject;
		randomLine = GameObject.Find("RandomLine").gameObject;
		endScore = GameObject.Find("EndScore").gameObject;
		tryAgain = GameObject.Find("TryAgain").gameObject;
		yes = GameObject.Find("Yes").gameObject;
		no = GameObject.Find("No").gameObject;

		endTimeGameOver = Time.time + 1;
		endTimeScore = Time.time + 2;
		endTimeRandomLine = Time.time + 3;
		endTimeOptions = Time.time + 4;

		endScore.guiText.text = "Score : " + score.GetComponent<Score>().score;
		DestroyObject(score);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
			askedForEnd = true;

		if(!isGameOverOnScreen && (askedForEnd || Timer (endTimeGameOver)))
		{
			isGameOverOnScreen = true;
			gameOver.guiText.color = new Color (gameOver.guiText.color.r, gameOver.guiText.color.g, gameOver.guiText.color.b, 1f);
		}
		if(!isScoreOnScreen && (askedForEnd || Timer (endTimeScore)))
		{
			isScoreOnScreen = true;
			endScore.guiText.color = new Color (endScore.guiText.color.r, endScore.guiText.color.g, endScore.guiText.color.b, 1f);
		}
		if(!isRandomLineOnScreen && (askedForEnd || Timer (endTimeRandomLine)))
		{
			isRandomLineOnScreen = true;
			randomLine.guiText.color = new Color (randomLine.guiText.color.r, randomLine.guiText.color.g, randomLine.guiText.color.b, 1f);
		}
		if(!areOptionsOnScreen && (askedForEnd || Timer (endTimeOptions)))
		{
			areOptionsOnScreen = true;
			tryAgain.guiText.color = new Color (tryAgain.guiText.color.r, tryAgain.guiText.color.g, tryAgain.guiText.color.b, 1f);
			yes.guiText.color = new Color (yes.guiText.color.r, yes.guiText.color.g, yes.guiText.color.b, 1f);
			no.guiText.color = new Color (no.guiText.color.r, no.guiText.color.g, no.guiText.color.b, 1f);
		}
	}



	bool Timer(float endTime){
		return((Time.time>=endTime)? true : false);
	}
}
