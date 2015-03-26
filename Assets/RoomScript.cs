using UnityEngine;
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
                Destroy(go);
            }
        }
    }
    private void GenerateWorld()
    {

        transform.GetComponent<Collider2D>().isTrigger = false;
        //  Debug.Log(squareOne.lossyScale.y);

        GameObject newSquare = (GameObject)Object.Instantiate(tileRed);
        tiles.Add(newSquare);
        GameObject newSquare2 = (GameObject)Object.Instantiate(tileBlack);
        tiles.Add(newSquare2);
        GameObject newSquare3 = (GameObject)Object.Instantiate(tileBlue);
        tiles.Add(newSquare3);
        GameObject newSquare4 = (GameObject)Object.Instantiate(tileGreen);
        tiles.Add(newSquare4);
        GameObject newSquare5 = (GameObject)Object.Instantiate(tileOrange);
        tiles.Add(newSquare5);
        GameObject newSquare6 = (GameObject)Object.Instantiate(tileYellow);
        tiles.Add(newSquare6);
        GameObject newSquare7 = (GameObject)Object.Instantiate(tilePurple);
        tiles.Add(newSquare7);
        GameObject newSquare8 = (GameObject)Object.Instantiate(tileWin);
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

}
