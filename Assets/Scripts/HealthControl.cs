using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthControl : MonoBehaviour {

    public Sprite health1;
    public Sprite health2;
    public Sprite health3;
    public Sprite health4;
    public Sprite health5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void updateLife(int playerLife)
    {
       Image image = gameObject.GetComponent<Image>();
        switch (playerLife)
        {
            case 5:
                image.sprite = health5;
                break;
            case 4:
                image.sprite = health4;
                break;
            case 3:
                image.sprite = health3;
                break;
            case 2:
                image.sprite = health2;
                break;
            case 1:
                image.sprite = health1;
                break;
        }
    }

}
