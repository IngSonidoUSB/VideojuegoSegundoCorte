using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour {

	// Desarrollado por: Nathalia Beltran

	public Text TimeText;
	public float Tiempo=0;
	int Minutos, segundos;
    public GameObject camara;
    private Vector3 posicion0;
    private Vector3 rb;
    private Vector3 posicion;
    private Vector3 rn;


    void Start()
    {
        Transform rb = camara.GetComponent<Transform>();
        posicion0 = rb.position;
    }
	// Update is called once per frame
	void Update () {

        Transform rn = camara.GetComponent<Transform>();
        posicion = rn.position;

        if (posicion==posicion0) {
            Tiempo = 0;
            }

        Tiempo += Time.deltaTime;
		Minutos = (int)Tiempo / 60;
		segundos = (int)Tiempo - (Minutos * 60);
		if (segundos <= 9) {
			TimeText.text = Minutos.ToString () + ":0" + segundos.ToString ();	
		} else {
			TimeText.text = Minutos.ToString () + ":" + segundos.ToString ();
		}
        
	}



}