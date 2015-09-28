using UnityEngine;
using System.Collections;

public class GenerateItem : MonoBehaviour {

	// Use this for initialization

    public GameObject Coin;
    public GameObject BlueGem;
    public GameObject OrangeGem;
    public GameObject YellowGem;
    public GameObject Heart;


	void Start () {
        int spawnSeed = Random.Range(0, 4);
        GameObject spawn = new GameObject();
        switch (spawnSeed)
        {
            case 0:
               spawn = Instantiate(Coin, transform.position, transform.rotation) as GameObject;
                Debug.Log("Coin Generated");
                break;
            case 1:
                spawn = GameObject.Instantiate(BlueGem, transform.position, transform.rotation) as GameObject;
                Debug.Log("Blue Gem generated");
                break;
            case 2:
                spawn = GameObject.Instantiate(OrangeGem, transform.position, transform.rotation) as GameObject;
                Debug.Log("Orange Gem generated");
                break;
            case 3:
                spawn = GameObject.Instantiate(YellowGem, transform.position, transform.rotation) as GameObject;
                Debug.Log("Yellow Gem generated");
                break;
           
        }
        spawn.transform.parent = transform;
            



	}
	
}
