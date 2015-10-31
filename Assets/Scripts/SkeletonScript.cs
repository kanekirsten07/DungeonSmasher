using UnityEngine;
using System.Collections;

public class SkeletonScript : CharacterScript {

	// Use this for initialization

    private int health = 2;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }



    void OnMouseDown()
    {
        Debug.Log("Ouch");
        doDamage();
    }
    void doDamage()
    {
        health--;

        if (health <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

   
}
