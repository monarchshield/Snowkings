using UnityEngine;
using System.Collections;

public class SpeedBoost : MonoBehaviour {

	//Using this to incriment the players movement speed
	//Just attatch this to objects and done! :)
	GameObject obj;
	PlayerInput player;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("Player1");
		player = obj.GetComponent<PlayerInput> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Debug.Log("Incrimenting speed");
			obj = other.gameObject;
			player = obj.GetComponent<PlayerInput> ();
			player.IncrimentSpeed(100);
		}



	}
}
