using UnityEngine;
using System.Collections;

public class RoatateCamera : MonoBehaviour {
	//How Senstive the camera movement should be?

	public float sensitivity = 5.0f;
	public float AccX;
	public float AccY;
	float Y;
	// Use this for initialization
	void Start () {
		Y = Input.acceleration.y;
	}
	
	// Update is called once per frame
	void Update () {
		
		AccX = Input.acceleration.x;
		AccY = Input.acceleration.y;

	//Rotate camera according to input
//		transform.eulerAngles += new Vector3 (-Input.GetAxis("Mouse Y") * senstivity, Input.GetAxis("Mouse X") * senstivity,0.0f);

//		transform.Rotate (2*(AccY-Y), -3 * AccX, 0);

		transform.Rotate (sensitivity  * AccY, sensitivity  * AccX,0);
	}
}
