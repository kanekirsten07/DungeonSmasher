using UnityEngine;
using System.Collections;

public class DemonScript : MonoBehaviour {

	// Use this for initialization
    // Target is the player, assign it in the inspector instead of looking for it in update
    public Transform target;
    public float maxSpeed = 0.5f;
    private Animator animator;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void walk()
    {
        float speed = 1.0f;
        //set the speed variable in the animation component to ensure proper state.
        animator.SetFloat("Speed", speed);

        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }

}
