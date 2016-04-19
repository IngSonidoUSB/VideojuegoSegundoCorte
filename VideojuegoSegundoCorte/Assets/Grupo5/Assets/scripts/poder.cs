using UnityEngine;
using System.Collections;

public class poder : MonoBehaviour
{
//DESARROLLADO POR: Angie Natalia Guerrero

    float Parpadeo = 0.1f;
    
    float val = 0.35f;
    float ran = 1f;
    // Use this for initialization
    void Start()
    {

    }

    
    void Update()
    {
       if(Input.GetKeyDown("space"))
        {
            StartCoroutine("WaitThreeSeconds");

        }

    }

     IEnumerator WaitThreeSeconds()
    {
        for (int i= 0; i < 6; i++)
        {

            GetComponent<Light>().enabled = false;
            yield return new WaitForSeconds(Parpadeo);
            GetComponent<Light>().enabled = true;
            GetComponent<Light>().intensity = val;
            GetComponent<Light>().range = ran;
            yield return new WaitForSeconds(Parpadeo);
            val = val + 0.35f;
            ran = ran + 1f;
        }
        yield return new WaitForSeconds(5);
        for (int o = 1; o < 15; o++)
        {
            val = val - 0.15f;
            ran = ran - 0.5f;
            GetComponent<Light>().intensity = val;
            GetComponent<Light>().range = ran;
            yield return new WaitForSeconds(0.05f);
        }
    }
        
    
}
    

