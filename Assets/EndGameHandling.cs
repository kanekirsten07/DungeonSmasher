using UnityEngine;
using System.Collections;
using Parse;

public class EndGameHandling : MonoBehaviour {

	GameObject scoreText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void continuePlaying()
	{
		scoreText = GameObject.Find("GameOverPopup").GetComponent<GameObject>();
		scoreText.SetActive(false);
	}
	public void endGame()
	{
		Application.LoadLevel("MainMenu");
        ParseObject testObject = new ParseObject("TestObject");
        testObject["foo"] = "bar";
        testObject.SaveAsync();
	}
}
