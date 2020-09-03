using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InteractWithCard : MonoBehaviour
{
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean touch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touch.GetStateDown(HandType))
        {
            Debug.Log("trigger");

        }
    }
}
