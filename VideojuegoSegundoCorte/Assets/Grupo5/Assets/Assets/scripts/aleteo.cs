using UnityEngine;
using FMOD.Studio;
using System.Collections;

public class aleteo : MonoBehaviour {

    [FMODUnity.EventRef]
    public string inputSound = "event:/murcielago";
    FMOD.Studio.EventInstance inputSoundEv;
    FMOD.Studio.ParameterInstance inputSoundParam;
    // Use this for initialization
    void Start () {
        inputSoundEv = FMODUnity.RuntimeManager.CreateInstance(inputSound);

        inputSoundEv.getParameter("velocidad", out inputSoundParam);
        
        inputSoundEv.start();
    }
	
	// Update is called once per frame
	void Update () {
        inputSoundParam.setValue(0.5f);
    }
}
