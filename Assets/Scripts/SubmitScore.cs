using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using Parse;
public class SubmitScore : MonoBehaviour {

	// Use this for initialization
    public InputField username;
     CharacterScript characterScript;
    public string usernameString ;
	
    void Awake()
    {
        Debug.Log("Awake Test");
        characterScript = (CharacterScript)FindObjectOfType(typeof(CharacterScript));
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void sendUserNameWithScore()
    {
        ParseObject submitScore = new ParseObject("SubmitScore");
        Debug.Log("Username: " + username.text.ToString());
        submitScore["username"] = username.text;
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
