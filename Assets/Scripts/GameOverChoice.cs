using UnityEngine;
using System.Collections;

public class GameOverChoice : MonoBehaviour {

	static int selectedButton = 0;
	public int buttonNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (guiText.fontStyle != FontStyle.Normal && selectedButton != buttonNumber)
			guiText.fontStyle = FontStyle.Normal;
		else if(guiText.fontStyle != FontStyle.Bold && selectedButton == buttonNumber)
			guiText.fontStyle = FontStyle.Bold;

		// If the player has selected an option, call it
		if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
			SelectOption ();
	}

	void OnMouseOver()
	{
		selectedButton = buttonNumber;
	}

	void OnMouseExit()
	{
		selectedButton = 0;
	}

	void OnMouseDown()
	{
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
