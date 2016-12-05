using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    [SerializeField]
    private Text textInfo;

    public string TextInformation
    {
        get
        {
            return textInfo.text;
        }
        set
        {
            textInfo.text = value;
        }
    }
}
