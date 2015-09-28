using UnityEngine;
using System.Collections;

public class WinRoomScript : MonoBehaviour {

    public GameObject gameOverPopup;
    public GameObject submitScorePopup;
	// Use this for initialization
	void Start () {
	
	}
	
	

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Entered room. Win Condition!");
            generateWinPopup();
        }
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

    public void sendUserNameWithScore()
    {

    }
}
