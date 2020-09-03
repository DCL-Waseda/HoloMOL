using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InteractWithCard : MonoBehaviour
{
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean touch;
    public GameObject edge;

    private bool isGrab = false;
    private bool isCollide = false;
    private GameObject cardObj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrab)
        {
            cardObj.transform.position = edge.transform.position;
            cardObj.transform.rotation = edge.transform.rotation;
        }

        if (touch.GetStateDown(HandType))
        {
            Debug.Log("trigger");

            if (isGrab)
            {
                isGrab = false;
                cardObj = null;
            }
            else
            {
                if (isCollide)
                {
                    isGrab = true;

                }
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "card")
        {
            Debug.Log("collide with card");
            isCollide = true;
            if (cardObj == null) 
            {
                cardObj = collision.gameObject;
            }
        }
        else
        {
            isCollide = false;
        }
    }
}
