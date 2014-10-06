using UnityEngine;
using System.Collections;

public class GameOverChoice : MonoBehaviour {

	static int selectedButton = 0;
	public int buttonNumber;

	GameOver gameOver;

	// Use this for initialization
	void Start () {
		gameOver = GameObject.Find("GameOverScreen(Clone)").gameObject.GetComponent<GameOver>();
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver.areOptionsOnScreen)
		{
			if (guiText.fontStyle != FontStyle.Normal && selectedButton != buttonNumber)
				guiText.fontStyle = FontStyle.Normal;
			else if(guiText.fontStyle != FontStyle.Bold && selectedButton == buttonNumber)
				guiText.fontStyle = FontStyle.Bold;
		}
	}

	void OnMouseEnter()
	{
		if(gameOver.areOptionsOnScreen)
		{
			selectedButton = buttonNumber;
			audio.Play();
		}
	}

	void OnMouseExit()
	{
		if(gameOver.areOptionsOnScreen)
			selectedButton = 0;
	}

	void OnMouseDown()
	{
		if(gameOver.areOptionsOnScreen)
			SelectOption();
	}

	void SelectOption()
	{
		switch(selectedButton)
		{
		case 1 :
			Application.LoadLevel("GameScene");
			break;
		case 2 :
			Application.LoadLevel("MenuScene");
			break;
		}
	}
	
}
