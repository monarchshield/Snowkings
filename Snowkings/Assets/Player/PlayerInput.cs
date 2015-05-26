using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public float thrust; //Just using it for direction
	public Rigidbody rb; //Used for getting the rigidbody component
	public SphereCollider bounds; 
<<<<<<< HEAD
=======
	Vector3 LastFrame;
	Vector3 Force;
	public Vector3 Currentsize;

	float cooldown;

	float MaxSize;

	public float SizeIncrimenter;

	KeyCode leftKey;
	KeyCode rightKey;

>>>>>>> 8ec37677070eaa17327b01c48b1faea7b5bfb174


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		bounds = GetComponent<SphereCollider> ();
		thrust = 10.0f;

<<<<<<< HEAD
=======
		MaxSize = 10; //Adjust this to adjust the maximum size the ball can go to

		cooldown = 1;
		SizeIncrimenter = 0; 

		Currentsize = new Vector3 (0, 0, 0);	//Debug stuff and thus irrelevant

		LastFrame = new Vector3 (0, 0, 0); //Dont need to touch this its just for directional velocity
		Force = new Vector3 (0, 0, 0);	   //Directional velocity calculation

		leftKey = KeyCode.A;
		rightKey = KeyCode.D;

>>>>>>> 8ec37677070eaa17327b01c48b1faea7b5bfb174
	}
	
	// Update is called once per frame
	void Update () {

<<<<<<< HEAD

		if (Input.GetKey (KeyCode.W)) {
			transform.localScale += new Vector3(.10F,.10F,.10F);
			bounds.radius += .00005f;

		}
=======
		Force =  this.transform.position - LastFrame;
	

	


		SizeIncrimenter += .00001f; //Change this to change the Size Incriment Uniform that is being called once per frame;
	
		if(transform.localScale.x < 10)
			transform.localScale += new Vector3 (SizeIncrimenter, SizeIncrimenter, SizeIncrimenter);
	
		//if (Input.GetKey (KeyCode.W)) {
		//	transform.localScale += new Vector3(.10F,.10F,.10F);
		//	Currentsize += new Vector3(.10F,.10F,.10F);
		//
		//	bounds.radius += .00005f;
		//
		//}
>>>>>>> 8ec37677070eaa17327b01c48b1faea7b5bfb174
	

		if (Input.GetKey (KeyCode.S)) {
			//TODO: Make the ball lose speed/velocity
			//e.g Make the ball slow down
<<<<<<< HEAD
			rb.AddForce(new Vector3(0,-1,0) * thrust);


		}

		if (Input.GetKey (KeyCode.A)) {
=======
			rb.AddForce(-Force * 100);
			//rb.velocity += Force;

		}

		if (Input.GetKey (leftKey)) {
>>>>>>> 8ec37677070eaa17327b01c48b1faea7b5bfb174
			//TODO: Add func here
			//Shift the ball to the left
			//transform.position.x += 1;
		
<<<<<<< HEAD
			rb.AddForce(new Vector3(1,0,0) * thrust);
		}

		if (Input.GetKey (KeyCode.D)) {
			//TODO: shift the ball to the right
			//transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
			rb.AddForce(new Vector3(-1,0,0) * thrust);



		}




	


	}
=======
			rb.AddForce(new Vector3(0,0,1) * thrust);
		}

		if (Input.GetKey (rightKey)) {
			//TODO: shift the ball to the right
			//transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
			rb.AddForce(new Vector3(0,0,-1) * thrust);
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


>>>>>>> 8ec37677070eaa17327b01c48b1faea7b5bfb174
}
