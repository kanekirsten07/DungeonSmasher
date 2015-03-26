using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour {

	// Use this for initialization
    int scoreModifier;
	void Start () {
        
        switch (gameObject.name)
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
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Picked up item");
        GameObject.Destroy(this.gameObject);
    }

}
