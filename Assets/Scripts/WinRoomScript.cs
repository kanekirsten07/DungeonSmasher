using UnityEngine;
using System.Collections;
using Parse;

public class WinRoomScript : MonoBehaviour {

    public GameObject gameOverPopup;
    public GameObject submitScorePopup;
	// Use this for initialization
	void Start () {
	
	}
    public void sendUserNameWithScore()
    {
        ParseObject submitScore = new ParseObject("SubmitScore");
        submitScore["testUsername"] = 2880;
        submitScore.SaveAsync();
    }
	


    void generateWinPopup()
    {
        GameObject.Instantiate(gameOverPopup);
    }

    public void dismissWindow()
    {
        Debug.Log("Dismiss Window");
        GameObject popup = GameObject.FindGameObjectWithTag("Finish");
        GameObject.Destroy(popup);
    }

    public void submitScore()
    {
        dismissWindow();
        Debug.Log("Submit Score");
        GameObject.Instantiate(submitScorePopup);
    }

    
}
