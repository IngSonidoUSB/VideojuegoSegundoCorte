using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class powersound : MonoBehaviour {

     
    public AudioClip power;
    private AudioSource Sound;
    bool imagenActiva = true;
    private GameObject imagen;

    // Use this for initialization
    void Start () {
        Sound = GetComponent<AudioSource>();
        Sound.clip = power;

        imagen.SetActive(imagenActiva);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && imagenActiva)
        {
            Sound.clip = power;
            Sound.Play();
        }







    }
}
