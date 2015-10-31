using UnityEngine;
using System.Collections.Generic;

public class WorldGenerator : MonoBehaviour {

	public GameObject tileRed; //<- make sure this has a material set on it.
	public GameObject tileBlack;
    public GameObject tileGreen;
    public GameObject tileBlue;
    public GameObject tileOrange;
    public GameObject tileYellow;
    public GameObject tilePurple;
    public GameObject tileWin;
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

        GameObject newSquare = generateRoom();
        tiles.Add(newSquare);
        GameObject newSquare2 = generateRoom();
       tiles.Add(newSquare2);
       GameObject newSquare3 = generateRoom();
        tiles.Add(newSquare3);
        GameObject newSquare4 = generateRoom();
        tiles.Add(newSquare4);
        GameObject newSquare5 = generateRoom();
        tiles.Add(newSquare5);
        GameObject newSquare6 = generateRoom();
        tiles.Add(newSquare6);
        GameObject newSquare7 = generateRoom();
       tiles.Add(newSquare7);
       GameObject newSquare8 = generateRoom();
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

    GameObject generateRoom()
    {
        int spawnSeed = Random.Range(0, 9);
        GameObject spawn = new GameObject();
        switch (spawnSeed)
        {
            case 0:
                spawn = (GameObject)Object.Instantiate(tileBlack);
                break;

        }

        return spawn;

    }

    bool playerIsWithinBounds()
    {
        return true;
    }
    

    
    void redrawBoard()
    {

    }
}
