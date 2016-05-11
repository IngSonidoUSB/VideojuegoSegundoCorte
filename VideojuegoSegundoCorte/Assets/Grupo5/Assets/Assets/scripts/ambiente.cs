using UnityEngine;
using FMOD.Studio;
using System.Collections;

public class ambiente : MonoBehaviour {

    [FMODUnity.EventRef]
    public string inputSound = "event:/ambiente";
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
