using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	public GameObject background;
	GUITexture logo;
	float endTime;
	bool isEndSplash;

	// Use this for initialization
	void Start () {
		logo = guiTexture;
		endTime = Time.time + 1;
		StartCoroutine(Fade(0, 1, 2, false));
	}
	
	// Update is called once per frame
	void Update () {
		if((Timer() || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0)) && !isEndSplash)
		{
			isEndSplash = true;
			StartCoroutine(Fade(1, 0, 2, isEndSplash));
		}
	}

	bool Timer(){
		return((Time.time>=endTime)? true : false);
	}

	IEnumerator Fade (float start, float end, float duration, bool endSplash) {
		float speed = 1/duration;  
		for (float t = 0; t < 1; t += Time.deltaTime*speed) {
			logo.color = new Color(logo.color.r, logo.color.g, logo.color.b, Mathf.Lerp(start, end, t));
			yield return null;
		}
		if(endSplash)
		{
			Instantiate(background);
			DestroyObject(gameObject);
		}
	}
}
