using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GunScript : MonoBehaviour
{
    public SteamVR_Action_Boolean Trigger;
    public SteamVR_Input_Sources hand;

    // Start is called before the first frame update
    void Start()
    {
        Trigger.AddOnStateDownListener(TriggerDown, hand);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.)
        
    }
}
