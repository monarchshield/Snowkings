using UnityEngine;
using System.Collections;

public class SizeBoost : MonoBehaviour {

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
			Debug.Log("Incrimenting size");
			obj = other.gameObject;
			player = obj.GetComponent<PlayerInput> ();
			player.IncrimentSize (new Vector3 (1, 1, 1));
		}
	
	}
}
