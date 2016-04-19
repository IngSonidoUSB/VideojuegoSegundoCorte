using UnityEngine;
using System.Collections;
using CnControls;

//Programado por Natalia Murcia
public class MovCamera : MonoBehaviour
{

    public float lookSpeed = 10;
    private Vector3 curLoc;
    private Vector3 prevLoc;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        float moveInputh = CnInputManager.GetAxis("Horizontal") * Time.deltaTime * 80;

        transform.Rotate(new Vector3(0, moveInputh, 0), Space.Self);

        float moveInputv = CnInputManager.GetAxis("Vertical") * Time.deltaTime * 10;
        transform.Translate(Vector3.forward * moveInputv);

    }




}
