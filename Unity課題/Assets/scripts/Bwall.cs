using UnityEngine;
using System.Collections;

public class Bwall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject cube = GameObject.Find ("Cube");
		cube.GetComponent<Renderer> ().material.color = new Color (1f, 0, 0, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			collider.gameObject.GetComponent<Renderer> ().material.color = new Color (0, 1, 0, 0.5f);
		}
	}
}
