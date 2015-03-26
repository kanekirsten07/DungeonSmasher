using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float playerSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * playerSpeed * Time.deltaTime;
            
        }

        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
        }
	}
}
