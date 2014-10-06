﻿using UnityEngine;
using System.Collections;

public class MainMenuChoice : MonoBehaviour {

	static int buttonSelected = 0;

	public int buttonNumber;
	public string buttonTextureName;
	public string buttonTextureSelectedName;

	Texture buttonTexture;
	Texture buttonSelectedTexture; 
	
	
	void Start()
	{
		buttonTexture = (Texture)Resources.Load(buttonTextureName, typeof(Texture));
		buttonSelectedTexture = (Texture)Resources.Load(buttonTextureSelectedName, typeof(Texture));
	}

	void Update()
	{
		// Update design of each option if needed
		if(buttonSelected == buttonNumber && guiTexture.texture != buttonSelectedTexture)
			guiTexture.texture = buttonSelectedTexture;
		else if(buttonSelected != buttonNumber && guiTexture.texture != buttonTexture)
			guiTexture.texture = buttonTexture;
	}
	
	void OnMouseEnter()
	{
		buttonSelected = buttonNumber;
		audio.Play();
	}

	void OnMouseExit()
	{
		buttonSelected = -1;
	}

	void OnMouseDown()
	{
		SelectOption();
	}

	void SelectOption()
	{
		switch(buttonSelected)
		{
		case 1 :
			Application.LoadLevel("GameScene");
			break;
		case 2 :
			// Launch options menu
			break;
		case 3 :
			Application.Quit();
			break;
		}
	}
}
