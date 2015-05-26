using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;


	// Use this for initialization
	void Start () {
<<<<<<< HEAD
=======

>>>>>>> 8ec37677070eaa17327b01c48b1faea7b5bfb174
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
