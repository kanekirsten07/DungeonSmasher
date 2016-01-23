using UnityEngine;
using System.Collections;

public class GenerateItem : MonoBehaviour {

	// Use this for initialization

    public GameObject Coin;
    public GameObject BlueGem;
    public GameObject OrangeGem;
    public GameObject YellowGem;
    public GameObject Heart;
    public GameObject AquaGem;
    public GameObject DarkBlueGem;
    public GameObject DarkPurpleGem;
    public GameObject GreenGem;
    public GameObject RedGem;


	void Start () {
        int spawnSeed = Random.Range(0, 9);
        GameObject spawn = null;
        switch (spawnSeed)
        {
            case 0:
               spawn = Instantiate(Coin, transform.position, transform.rotation) as GameObject;
              //  Debug.Log("Coin Generated");
                break;
            case 1:
                spawn = GameObject.Instantiate(BlueGem, transform.position, transform.rotation) as GameObject;
               // Debug.Log("Blue Gem generated");
                break;
            case 2:
                spawn = GameObject.Instantiate(OrangeGem, transform.position, transform.rotation) as GameObject;
               // Debug.Log("Orange Gem generated");
                break;
            case 3:
                spawn = GameObject.Instantiate(YellowGem, transform.position, transform.rotation) as GameObject;
               // Debug.Log("Yellow Gem generated");
                break;
            case 4:
                spawn = GameObject.Instantiate(AquaGem, transform.position, transform.rotation) as GameObject;
                break;
            case 5:
                spawn = GameObject.Instantiate(DarkBlueGem, transform.position, transform.rotation) as GameObject;
                break;
            case 6:
                spawn = GameObject.Instantiate(DarkPurpleGem, transform.position, transform.rotation) as GameObject;
                break;
            case 7:
                spawn = GameObject.Instantiate(GreenGem, transform.position, transform.rotation) as GameObject;
                break;
            case 8:
                spawn = GameObject.Instantiate(RedGem, transform.position, transform.rotation) as GameObject;
                break;

           
        }
        spawn.transform.parent = transform;
            



	}
	
}
