using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision otherObj) {
		if (otherObj.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}


}

