﻿using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public float thrust; //Just using it for direction
	public Rigidbody rb; //Used for getting the rigidbody component
	public SphereCollider bounds; 
	Vector3 LastFrame;
	Vector3 Force;
	public Vector3 Currentsize;

	KeyCode leftKey;
	KeyCode rightKey;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		bounds = GetComponent<SphereCollider> ();
		thrust = 10.0f;

		Currentsize = new Vector3 (0, 0, 0);

		LastFrame = new Vector3 (0, 0, 0);
		Force = new Vector3 (0, 0, 0);

		leftKey = KeyCode.A;
		rightKey = KeyCode.D;

	}
	
	// Update is called once per frame
	void Update () {

		Force =  this.transform.position - LastFrame;


		if (Input.GetKey (KeyCode.W)) {
			transform.localScale += new Vector3(.10F,.10F,.10F);
			Currentsize += new Vector3(.10F,.10F,.10F);

			bounds.radius += .00005f;

		}
	

		if (Input.GetKey (KeyCode.S)) {
			//TODO: Make the ball lose speed/velocity
			//e.g Make the ball slow down
			rb.AddForce(Force * 100);
			//rb.velocity += Force;

		}

		if (Input.GetKey (leftKey)) {
			//TODO: Add func here
			//Shift the ball to the left
			//transform.position.x += 1;
		
			rb.AddForce(new Vector3(1,0,0) * thrust);
		}

		if (Input.GetKey (rightKey)) {
			//TODO: shift the ball to the right
			//transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
			rb.AddForce(new Vector3(-1,0,0) * thrust);
		}


		LastFrame = transform.position;
	}

	public void IncrimentSize(Vector3 Scale)
	{
		transform.localScale += Scale;
	}

	public void IncrimentSpeed(float Multiplier)
	{
		rb.velocity += Force * Multiplier;
	}

	public void IncrimentMass(float mass)
	{
		rb.mass += mass;
	}

	public void ReduceSize(Vector3 SizeReduction)
	{
		transform.localScale -= SizeReduction;
	}

	public void ReduceSpeed(float Multiplier)
	{
		rb.velocity -= -Force * Multiplier;
	}

	public void InitaliseKeys(KeyCode left, KeyCode right)
	{
		leftKey = left;
		rightKey = right;
	}


}
