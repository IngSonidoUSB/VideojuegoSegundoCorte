using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MOVE : MonoBehaviour {

	public ElementoInteractivo Poder;
	public ElementoInteractivo Aceler;
	public Scrollbar Barra;
	public GameObject Winn;

	public float Mov_Speed = 1;
	Light Ecoloc;
	public bool Colision;
	float PP=1;

		void Start () {

		Ecoloc = GetComponent<Light> ();
		Barra = GameObject.Find ("HealthBar").GetComponent<Scrollbar>();
		
		}

		void Update(){


		transform.Rotate (0.0f, Input.GetAxis("Horizontal") * 3, 0.0f);

		if(Aceler.pulsado) {
			
			transform.position = transform.position + transform.forward * Mov_Speed;

		} else if (Input.GetKey(KeyCode.S)) {

			transform.position = transform.position - transform.forward * Mov_Speed/2;

		}

		if ((Input.GetKey (KeyCode.Space) == false || Poder.pulsado == false) && PP < 1) {
			PP = PP + 0.0005f;
		}

		Barra.size = PP;

		if ((Input.GetKey (KeyCode.Space) || Poder.pulsado) && PP > 0.01) {


			PP = PP - 0.01f;
			if (PP < 0) {
				PP = 0;
			}

			if (Ecoloc.intensity <= 8) { 
				
				Ecoloc.intensity = Ecoloc.intensity + 0.1f;
			}
		
		} else {

			if (Ecoloc.intensity > 0) {

			
				Ecoloc.intensity = Ecoloc.intensity - 1;
			} 
		
		}


	}

	void OnTriggerEnter(Collider Col) {
		if (Col.gameObject.tag == "Flies") {
			Colision = true;
			Destroy (Col.gameObject);
			PP = PP + 0.15f;
			if (PP > 1) {
				PP = 1;
			}
		}
			
if(Col.gameObject.name == "Flies (13)" || Col.gameObject.name == "Flies (15)" || Col.gameObject.name == "Flies (16)" || Col.gameObject.name == "Flies (17)") {
			Winn.SetActive (true);
		}

		if (Col.gameObject.tag == "Spider") {
			SceneManager.LoadScene("Bat@ss");
		}
	}


//	public void ChangeToScene (){
//		Application.LoadLevel ("Bat@ss");
//	}

}