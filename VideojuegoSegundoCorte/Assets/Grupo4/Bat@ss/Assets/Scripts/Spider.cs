using UnityEngine;
using System.Collections;

public class Spider : MonoBehaviour {

	// Use this for initialization

	public GameObject PlayerObject;
    public Animation Animation;
    public float PlayerDistance;
    public float RotationSpeed = 0.001f;
    public float MovementSpeed = 10;
    private Quaternion LookRotation;
    private Vector3 Direction;
    private Vector3 TargetPosition;
    

	void Start () {

        PlayerObject = GameObject.Find("Player");
        Animation = GetComponent<Animation>();
	
	}

    // Update is called once per frame
    void Update() {

        

        PlayerDistance = Vector3.Distance(PlayerObject.transform.position, transform.position);

        if (PlayerDistance <  60) {

            Animation.Play("Run"); 

            Direction = new Vector3((PlayerObject.transform.position.x - transform.position.x), 0, (PlayerObject.transform.position.z - transform.position.z));

            LookRotation = Quaternion.LookRotation(Direction);

            transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, RotationSpeed);

            TargetPosition = new Vector3(PlayerObject.transform.position.x, 0, PlayerObject.transform.position.z);

            transform.position = Vector3.MoveTowards(transform.position, TargetPosition, Time.deltaTime * MovementSpeed);
        } else
        {
            Animation.Play("Idle");
        }


        
	
	}
}
