using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   public void startNewGame()
    {
        Application.LoadLevel("Maze2D");
    }

    public void viewHighScores()
    {
        Application.LoadLevel("HighScoreView");
    }
}
