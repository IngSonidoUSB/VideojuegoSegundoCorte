using UnityEngine;
using System;
using System.Collections;

public class Destroy : MonoBehaviour {
	public String Event;

	public String CollisionTag;
	public bool AllowFadeout = true;
	public bool TriggerOnce = false;


	private bool hasTriggered;
	private bool isQuitting;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {
			Destroy (gameObject);
		}
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (String.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
		{
			Destroy(gameObject);
		}
	}


}
