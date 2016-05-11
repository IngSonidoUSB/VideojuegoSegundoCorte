using UnityEngine;
using FMOD.Studio;
using System.Collections;

public class sapos : MonoBehaviour {

    [FMODUnity.EventRef]
    public string inputSound = "event:/sapos";
    FMOD.Studio.EventInstance inputSoundEv;
    FMOD.Studio.ParameterInstance inputSoundParam;

    // Use this for initialization
    void Start () {
        inputSoundEv = FMODUnity.RuntimeManager.CreateInstance(inputSound);
        inputSoundEv.start();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
