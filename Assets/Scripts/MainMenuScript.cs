using UnityEngine;
using Parse;
using System.Threading.Tasks;
using UnityEngine.UI;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    // Use this for initialization

    public static IEnumerable results;
    public GameObject TopTen;
    bool isDoneLoading = false;
    void Awake()
    {
        viewHighScores();
    }
    void Start () {
        TopTen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if(isDoneLoading)
        {
            updateUI();
            isDoneLoading = false;
        }
    }

   public void startNewGame()
    {
        Application.LoadLevel("Maze2D");
    }

public void viewHighScores()
    {

        //MainMenuUI mainMenuUI = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<MainMenuUI>();
        Debug.Log("Retrieve high scores");
        var query = ParseObject.GetQuery("SubmitScore").OrderByDescending("userScore").Limit(10);
        GameObject text1 = GameObject.Find("Slot0");
         query.FindAsync().ContinueWith(t =>
         {
              results = t.Result;
             Debug.Log("Done");
             isDoneLoading = true;
         });
        
        //   Application.LoadLevel("HighScoreView");
    }



    public void updateUI()
    {
        if (isDoneLoading)
        {
            TopTen.SetActive(true);
            int index = 0;
            foreach (ParseObject result in results)
            {
                GameObject text = GameObject.Find("Slot" + index);
                text.GetComponent<Text>().text = result.Get<string>("username") + result.Get<int>("userScore");
                //.GetComponent<Text>().text = "Penis";
                index++;
            }
        }else
        {
            Debug.Log("Loading, Please wait.");
        }
    }
}
