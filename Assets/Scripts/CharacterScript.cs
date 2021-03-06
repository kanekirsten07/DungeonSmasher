﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterScript : MonoBehaviour {

    //max speed of character
    public float maxSpeed = 1.0f;
    public int health;
	public int totalScore ;
    public Text scoreText;
    private Animator animator;
    GameObject image;
    private Rigidbody2D cachedRigidBody2D;
    
    public float facingAngleAdjustment = -90.0f;
  
    /// <summary>
    /// Initialization function that needs to interact 
    /// with other components or objects that must be 
    /// initialized prior to working with them.
    /// </summary>
    private void Start()
    {
        //cached animator
        this.animator = this.GetComponent<Animator>();
        //cached rigidbody
        this.cachedRigidBody2D = this.GetComponent<Rigidbody2D>();
        totalScore = 0;
        image = GameObject.FindGameObjectWithTag("Health");
    }
 
    public void Move(Vector2 movement)
    {
        //move the rigid body, which is part of the physics system
        //This ensures smooth movement.
        this.cachedRigidBody2D.velocity = new Vector2(movement.x * maxSpeed, movement.y * maxSpeed);
 
        //take the absolute value and add, because x or y 
        //may be negative and potentially cancel eachother out.
        float speed = Mathf.Abs(movement.x) + Mathf.Abs(movement.y);
 
        //set the speed variable in the animation component to ensure proper state.
        animator.SetFloat("Speed", speed);

        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg + -facingAngleAdjustment;

        //don't rotate if we don't need to.
        if (speed > 0.0f)
        {
            //rotate by angle around the z axis.
           transform.rotation = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Demon")
        {
            image.GetComponent<HealthControl>().updateLife(--health);
        }
    }


	public void addToScore(int scoreValue)
	{
		totalScore += scoreValue;
        scoreText.text = "Score: " + totalScore;
	}

	public int getScore()
	{
		return totalScore;
	}

}
