using UnityEngine;
using System.Collections;

public class DecrimentSnowball : MonoBehaviour {

	// Use this for initialization

	GameObject obj;
	PlayerInput player;

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
			player.ReduceSize(new Vector3(1,1,1));
			player.IncrimentSpeed(.5f);
		}
		
	}

}
