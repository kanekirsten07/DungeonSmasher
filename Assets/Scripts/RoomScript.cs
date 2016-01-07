using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomScript : MonoBehaviour {

    public GameObject tileRed; 
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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Entered room. Generating world.");

            cleanUpOldRooms();
            GenerateWorld();
        }
    }

    
    private void cleanUpOldRooms()
    {

        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");
        
        foreach (GameObject go in rooms)
        {
            if (go.transform != transform)
            {
                foreach (Transform child in go.transform)
                {
                    Destroy(child.gameObject);
                }
                //DestroyImmediate(go);
                Destroy(go.gameObject);
            }
        }
    }
    private void GenerateWorld()
    {

        transform.GetComponent<Collider2D>().isTrigger = false;
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

        Transform t = transform.FindChild("Brick");
        float scaleOffsetX = t.GetComponent<Renderer>().bounds.size.x * 2;
        float scaleOffsetY = t.GetComponent<Renderer>().bounds.size.y * 2;

        newSquare.transform.position = new Vector3(transform.position[0] + scaleOffsetX, transform.position[1], transform.position[2]);
        newSquare2.transform.position = new Vector3(transform.position[0] - scaleOffsetX, transform.position[1], transform.position[2]);

        newSquare3.transform.position = new Vector3(transform.position[0], transform.position[1] + scaleOffsetY, transform.position[2]);
        newSquare4.transform.position = new Vector3(transform.position[0], transform.position[1] - scaleOffsetY, transform.position[2]);


        newSquare5.transform.position = new Vector3(transform.position[0] + scaleOffsetX, transform.position[1] - scaleOffsetY, transform.position[2]);
        newSquare6.transform.position = new Vector3(transform.position[0] - scaleOffsetX, transform.position[1] + scaleOffsetY, transform.position[2]);
        newSquare7.transform.position = new Vector3(transform.position[0] + scaleOffsetX, transform.position[1] + scaleOffsetY, transform.position[2]);
        newSquare8.transform.position = new Vector3(transform.position[0] - scaleOffsetX, transform.position[1] - scaleOffsetY, transform.position[2]);
        transform.GetComponent<Collider2D>().isTrigger = true;
    }


    GameObject generateRoom()
    {
        int spawnSeed = Random.Range(0, 7);
        GameObject spawn = new GameObject();
        switch (spawnSeed)
        {
            case 0:
                spawn = (GameObject)Object.Instantiate(tileBlack);
                break;
            case 1:
                spawn = (GameObject)Object.Instantiate(tileRed);
                break;
            case 2:
                spawn = (GameObject)Object.Instantiate(tileBlue);
                break;
            case 3:
                spawn = (GameObject)Object.Instantiate(tileGreen);
                break;
            case 4:
                spawn = (GameObject)Object.Instantiate(tileOrange);
                break;
            case 5:
                spawn = (GameObject)Object.Instantiate(tilePurple);
                break;
            case 6:
                spawn = (GameObject)Object.Instantiate(tileWin);
                break;
        }

        return spawn;

    }

}
