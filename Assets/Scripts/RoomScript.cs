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

    public GameObject brick;

     List<GameObject> tiles;

    void Start()
    {
        tiles = new List<GameObject>();
    }
  

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Entering room.");
            transform.GetComponent<Collider2D>().isTrigger = false;
            Debug.Log(transform.GetComponent<Collider2D>().isTrigger);
            cleanUpOldRooms();
            GenerateWorld();
        }
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Leaving room");
        
    }

    
    private void cleanUpOldRooms()
    {
        // You don't need to use a find here. Find is an expensive call, and you actually already have all the references you need
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");

        //GameObject[] rooms = { tileRed, tileBlack, tileGreen, tileBlue, tileOrange, tileYellow, tilePurple, tileWin };
        
        // If you don't want to have to create this array manually, there are potential drawbacks; however, another approach would be:
        // Create a public GameObject[] array. This will allow you in the editor to drop as many room tile prefabs onto it as you want
        // From there, you can create additional tags for the rooms, and reference the rooms based on their tags. Or use an enum and strictly number the rooms.
        // The enum approach is probably the most risky though, since it's fragile with ordering.

        foreach (GameObject go in rooms)
        {
            if (go.transform != transform)
            {
                foreach (Transform child in go.transform)
                {
                    Destroy(child.gameObject);
                }
                Destroy(go.gameObject);
            }
        }
       
        
    }
    private void GenerateWorld()
    {

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

        newSquare.GetComponent<Collider2D>().isTrigger = true;
        newSquare2.GetComponent<Collider2D>().isTrigger = true;
        newSquare3.GetComponent<Collider2D>().isTrigger = true;
        newSquare4.GetComponent<Collider2D>().isTrigger = true;
        newSquare5.GetComponent<Collider2D>().isTrigger = true;
        newSquare6.GetComponent<Collider2D>().isTrigger = true;
        newSquare7.GetComponent<Collider2D>().isTrigger = true;
        newSquare8.GetComponent<Collider2D>().isTrigger = true;
        transform.GetComponent<Collider2D>().isTrigger = true;

    

    }


    GameObject generateRoom()
    {
        int spawnSeed = Random.Range(0, 7);
        GameObject spawn = null;
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
