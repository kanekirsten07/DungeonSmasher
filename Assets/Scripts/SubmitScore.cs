using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using Parse;

public class SubmitScore : MonoBehaviour {

	// Use this for initialization
    public InputField username;
    public int scoreString;
    public CharacterScript characterScript;
    public string usernameString ;
	
    void Awake()
    {
        Debug.Log("Awake Test");
    }

    void Start()
    {
        characterScript = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterScript>();
        scoreString = characterScript.totalScore;
    }
	
	
    public void sendUserNameWithScore()
    {

        usernameString = username.text;
        characterScript = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterScript>();
        ParseObject submitScore = new ParseObject("SubmitScore");
        Debug.Log("Username: " + username.text.ToString());
        Debug.Log("Score: " + characterScript.totalScore);
        submitScore["username"] =  username.text;
        submitScore["userScore"] = characterScript.totalScore;
        submitScore.SaveAsync();
        //dismissWindow();
    }


    public void updateUsername()
    {
        usernameString = username.text;
        Debug.Log("username" + usernameString);
    }


    public void dismissWindow()
    {
        Debug.Log("Dismiss Window");
        GameObject popup = GameObject.FindGameObjectWithTag("Score");
        GameObject.Destroy(popup);
    }

}
