using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class choque : MonoBehaviour {

    public AudioClip murcielago;
    //public AudioClip golpe;
    private AudioSource Sound;

    void Start () {
        Sound = GetComponent<AudioSource>();
        Sound.clip = murcielago;
        //Sound.clip = golpe;
    }
	
	// Update is called once per frame
	void Update () {


    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "murcielago")
        {
            Sound.clip = murcielago;
            //Sound.clip = golpe;
            Sound.Play();
        }
    }
}
