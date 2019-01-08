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
        if (ctl0.ControllerInputDevice.GetButton(GvrControllerButton.Trigger) || ctl1.ControllerInputDevice.GetButton(GvrControllerButton.Trigger)) { 
            latk.clicked = true;
        } else {
            latk.clicked = false;
        }
    }

}
