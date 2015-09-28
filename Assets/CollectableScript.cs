using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour {

	// Use this for initialization
    int scoreModifier = 0;
    public CharacterScript characterScript;
	void Start () {

      
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Picked up item");

            addToScore();
        }
    }


    void addToScore()
    {
        characterScript = (CharacterScript)FindObjectOfType(typeof(CharacterScript));
        Debug.Log(this.gameObject.tag);
        switch (this.gameObject.tag)
        {
            case "Coin":
                scoreModifier = 10;
                break;
            case "BlueGem":
                scoreModifier = 25;
                break;
            case "OrangeGem":
                scoreModifier = 50;
                break;
            case "YellowGem":
                scoreModifier = 100;
                break;

                
        }
        characterScript.addToScore(scoreModifier);
        GameObject.Destroy(this.gameObject);
    }

}
