using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	private GameObject player = null;
	private Vector3 offset = Vector3.zero;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		newPosition.x = player.transform.position.x + offset.x;
		newPosition.y = player.transform.position.y + offset.y;
		newPosition.z = player.transform.position.z + offset.z;
		transform.position = newPosition;
	}
}
