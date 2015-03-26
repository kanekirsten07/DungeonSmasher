using UnityEngine;
using System.Collections.Generic;

public class WorldGenerator : MonoBehaviour {

	public GameObject tileRed; //<- make sure this has a material set on it.
	public GameObject tileBlack;
    public GameObject tileGreen;
    public List<GameObject> tiles;
	private uint worldWidth = 3;
	private uint worldHeight = 3;
     Transform squareOne;
	GameObject tile;
	// Use this for initialization
	void Start () {
		this.CreateWorld();
        tiles = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        GameObject go = GameObject.Find("Player");
        Transform playercoords = go.transform;
        Vector2 player = playercoords.position;

        for (int i = 0; i < tiles.Count; i++)
        {
            if (playerIsWithinBounds())
            {
                redrawBoard();
            }
        }
      
	}

    private void CreateWorld()
    {
      GameObject go =  GameObject.Find("BaseRoom");
    
        Transform squareOne = go.transform;
      //  Debug.Log(squareOne.lossyScale.y);

        GameObject newSquare = (GameObject) Object.Instantiate(tileBlack);
        tiles.Add(newSquare);
        GameObject newSquare2 = (GameObject)Object.Instantiate(tileBlack);
       tiles.Add(newSquare2);
        GameObject newSquare3 = (GameObject)Object.Instantiate(tileBlack);
        tiles.Add(newSquare3);
        GameObject newSquare4 = (GameObject)Object.Instantiate(tileBlack);
        tiles.Add(newSquare4);
        GameObject newSquare5 = (GameObject)Object.Instantiate(tileGreen);
        tiles.Add(newSquare5);
        GameObject newSquare6 = (GameObject)Object.Instantiate(tileGreen);
        tiles.Add(newSquare6);
        GameObject newSquare7 = (GameObject)Object.Instantiate(tileGreen);
       tiles.Add(newSquare7);
        GameObject newSquare8 = (GameObject)Object.Instantiate(tileGreen);
        tiles.Add(newSquare8);

        float scaleOffsetX = 0.50f;
        float scaleOffsetY = 0.38f;

        newSquare.transform.position = new Vector3(squareOne.position[0] + scaleOffsetX, squareOne.position[1], squareOne.position[2]);
        newSquare2.transform.position = new Vector3(squareOne.position[0] - scaleOffsetX, squareOne.position[1], squareOne.position[2]);
        newSquare3.transform.position = new Vector3(newSquare.transform.position[0], squareOne.position[1] + scaleOffsetY, newSquare.transform.position[2]);
        newSquare4.transform.position = new Vector3(squareOne.position[0], squareOne.position[1] - scaleOffsetY, squareOne.position[2]);


        newSquare5.transform.position = new Vector3(squareOne.position[0] + scaleOffsetX, squareOne.position[1] - scaleOffsetY, squareOne.position[2]);
        newSquare6.transform.position = new Vector3(squareOne.position[0] - scaleOffsetX, squareOne.position[1] + scaleOffsetY, squareOne.position[2]);
        newSquare7.transform.position = new Vector3(squareOne.position[0] + scaleOffsetX, squareOne.position[1] + scaleOffsetY, squareOne.position[2]);
        newSquare8.transform.position = new Vector3(squareOne.position[0] - scaleOffsetX, squareOne.position[1] - scaleOffsetY, squareOne.position[2]);
         
	}

    bool playerIsWithinBounds()
    {
        return true;
    }
    

    
    void redrawBoard()
    {

    }
}
