using UnityEngine;
using System.Collections;

public class Victoria : MonoBehaviour {

	// Desarrollado por: Nathalia Milena Beltran 
	// Use this for initialization
	public GameObject victoria;


	void OnCollisionEnter (){

		victoria.SetActive (true);
		Time.timeScale = 0;
	
	}

}
