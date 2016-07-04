using UnityEngine;
using System.Collections;

public class Bwall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
	/*void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			collider.gameObject.GetComponent<Renderer> ().material.color = new Color (0, 1, 0, 0.5f);
		}
	}*/
	private void OnCollisionEnter(Collision collider) {

		if(collider.gameObject.name == "unitychan") {
			Destroy(gameObject);
		}
	}
}
