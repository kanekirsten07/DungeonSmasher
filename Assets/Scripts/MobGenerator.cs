using UnityEngine;
using System.Collections;

public class MobGenerator : MonoBehaviour {

    public GameObject demon;
	// Use this for initialization
	void Start () {
	
         int spawnSeed = Random.Range(0, 5);
        GameObject spawn = null;
        switch (spawnSeed)
        {
            case 0:
                spawn = Instantiate(demon, transform.position, transform.rotation) as GameObject;
                spawn.transform.parent = transform;
                Debug.Log("Demon Generated");
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
