using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public float thrust; //Just using it for direction
	public Rigidbody rb; //Used for getting the rigidbody component
	public SphereCollider bounds; 


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		bounds = GetComponent<SphereCollider> ();
		thrust = 10.0f;

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.W)) {
			transform.localScale += new Vector3(.10F,.10F,.10F);
			bounds.radius += .00005f;

		}
	

		if (Input.GetKey (KeyCode.S)) {
			//TODO: Make the ball lose speed/velocity
			//e.g Make the ball slow down
			rb.AddForce(new Vector3(0,-1,0) * thrust);


		}

		if (Input.GetKey (KeyCode.A)) {
			//TODO: Add func here
			//Shift the ball to the left
			//transform.position.x += 1;
		
			rb.AddForce(new Vector3(1,0,0) * thrust);
		}

		if (Input.GetKey (KeyCode.D)) {
			//TODO: shift the ball to the right
			//transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
			rb.AddForce(new Vector3(-1,0,0) * thrust);



		}




	


	}
}
