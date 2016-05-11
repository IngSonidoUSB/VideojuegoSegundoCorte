using UnityEngine;
using FMOD.Studio;
using System.Collections;
using CnControls;
using UnityEngine.UI;

//Programado por Natalia Murcia
[RequireComponent(typeof(AudioSource))]
public class MovCamera : MonoBehaviour
{
    public AudioClip murcielago;
    private AudioSource Sound;

    public Text TimeText;
    public Text mayort;
    public float lookSpeed = 10;
    private Vector3 curLoc;
    private float prevLoc;
    private bool golpe = false;
    private bool reiniciar = false;
    public float estado = 0.34f;
    public float Tiempo;
    int Minutos, segundos;
    private Vector3 rb;
    private Vector3 posicion0;
    public GameObject victoria;
    public int suma=0;
    private int mayor;
    private int[] almacenarT = new int[1000];

    private int x = -1;
    private Vector3 posicion;
    private Vector3 rn;

    [FMODUnity.EventRef]
    public string inputSound = "event:/murcielago";
    FMOD.Studio.EventInstance inputSoundEv;
    FMOD.Studio.ParameterInstance inputSoundParam;

    // Use this for initialization
    void Start()
    {

        Sound = GetComponent<AudioSource>();
        Sound.clip = murcielago;
        Transform rb = GetComponent<Transform>();
        posicion0= rb.position;

        inputSoundEv = FMODUnity.RuntimeManager.CreateInstance(inputSound);

        inputSoundEv.getParameter("velocidad", out inputSoundParam);

        inputSoundEv.start();

    }

    // Update is called once per frame
    void Update()
    {


        float moveInputh = CnInputManager.GetAxis("Horizontal") * Time.deltaTime * 80;

        if (golpe == false)
        {
            transform.Rotate(new Vector3(0, moveInputh, 0), Space.Self);

            float moveInputv = CnInputManager.GetAxis("Vertical") * Time.deltaTime * 10;
            transform.Translate(Vector3.forward * moveInputv);
            prevLoc = moveInputv;


        }


       // instrumento();

        //inputSoundParam.setValue(estado);

        Tiempo += Time.deltaTime;
        Minutos = (int)Tiempo / 60;
        segundos = (int)Tiempo - (Minutos * 60);
        if (segundos <= 9)
        {
            TimeText.text = Minutos.ToString() + ":0" + segundos.ToString();
        }
        else
        {
            TimeText.text = Minutos.ToString() + ":" + segundos.ToString();
        }

    }



    void instrumento()
    {
        if (Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {

            estado = 0.5f;
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("down"))
        {
            estado = 0.3f;
        }


    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "paredes")
        {

            golpe = true;
            Sound.clip = murcielago;
            Sound.Play();


        }

        if (col.gameObject.tag == "pared0")
        {

             victoria.SetActive(true);
             transform.position = posicion0;
             x = x + 1;
             almacenarT[x] = (int)Tiempo;

            if (x == 0)
            {
                mayor = almacenarT[0];
            }
            else { 
            for (int f = 0; f < x+1; f++)
            {

                    if (almacenarT[f] < mayor)
                    {
                        mayor = almacenarT[f];

                    }
                }
            }

            Minutos = mayor / 60;
            segundos = mayor - (Minutos * 60);
            if (segundos <= 9)
            {
                mayort.text = Minutos.ToString() + ":0" + segundos.ToString();
            }
            else
            {
                mayort.text = Minutos.ToString() + ":" + segundos.ToString();
            }

            Tiempo = 0;
                
            }

    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "paredes")
        {
            golpe = false;
        }

    }



}
