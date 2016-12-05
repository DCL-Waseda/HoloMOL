using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject InformationPrefabs;

    public void GenerateBlock(string message)
    {
        var obj = Utility.InstantiateGetComponent<Information>(null, InformationPrefabs);
        obj.transform.position = Camera.main.transform.position + new Vector3(0, 0, 3f);
        obj.TextInformation = "message";
        //obj.gameObject.AddComponent<Rigidbody>();
    }

    private void Update()
    {
        var touch = TouchUtility.GetTouch(0);
        switch (touch)
        {
            case TouchInfo.Began:
                GenerateBlock("TEST");
                break;
        }
    }
}
