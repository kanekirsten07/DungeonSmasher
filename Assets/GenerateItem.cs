using UnityEngine;
using System.Collections;

public class GenerateItem : MonoBehaviour {

	// Use this for initialization

    public GameObject Coin;
    public GameObject BlueGem;
    public GameObject OrangeGem;
    public GameObject YellowGem;

	void Start () {
        int spawnSeed = Random.Range(0, 4);
        switch (spawnSeed)
        {
            case 0:
                GameObject.Instantiate(Coin, transform.position, transform.rotation);
                Debug.Log("Coin Generated");
                break;
            case 1:
                GameObject.Instantiate(BlueGem, transform.position, transform.rotation);
                Debug.Log("Blue Gem generated");
                break;
            case 2:
                GameObject.Instantiate(OrangeGem, transform.position, transform.rotation);
                Debug.Log("Orange Gem generated");
                break;
            case 3:
                GameObject.Instantiate(YellowGem, transform.position, transform.rotation);
                Debug.Log("Yellow Gem generated");
                break;
        }



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
