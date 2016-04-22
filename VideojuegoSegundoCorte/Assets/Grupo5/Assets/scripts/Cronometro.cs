using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour {

	// Desarrollado por: Nathalia Beltran

	public Text TimeText;
	float Tiempo;
	int Minutos, segundos;

	// Update is called once per frame
	void Update () {
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