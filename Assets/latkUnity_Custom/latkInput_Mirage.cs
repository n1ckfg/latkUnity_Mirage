using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latkInput_Mirage : MonoBehaviour {

    public LightningArtist latk;
    public GvrTrackedController ctl0;
    public GvrTrackedController ctl1;

    private void Awake() {
        if (latk == null) latk = GetComponent<LightningArtist>();
    }

    void Start () {
		
	}
	
	void Update () {
        if (ctl0.ControllerInputDevice.GetButton(GvrControllerButton.Trigger)) { 
            latk.clicked = true;
        } else {
            latk.clicked = false;
        }

		if (ctl0.ControllerInputDevice.GetButtonDown(GvrControllerButton.Grip)) {
			latk.inputNewFrame();
		}

		if (ctl1.ControllerInputDevice.GetButtonDown(GvrControllerButton.Trigger)) {
			latk.inputPlay();
		}

		if (ctl1.ControllerInputDevice.GetButtonDown(GvrControllerButton.Grip)) {
			latk.inputEraseLastStroke();
		}
    }

}
