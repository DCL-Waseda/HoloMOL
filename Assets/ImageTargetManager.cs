using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetManager : MonoBehaviour
{
    [SerializeField]
    private DefaultTrackableEventHandler[] imageTargets;

    public static int ActiveTarget = -1;
    private static int BeforeActiveTarget = -1;

    void Start()
    {
        for (var i = 0; i < imageTargets.Length; i++)
        {
            //imageTargets[i].TargetId = i;
        }
    }

    void Update()
    {
        if (BeforeActiveTarget != ActiveTarget)
        {
            RemoveOtherTarget(ActiveTarget);
        }
        BeforeActiveTarget = ActiveTarget;
    }

    private void RemoveOtherTarget(int id)
    {
        for (var i = 0; i < imageTargets.Length; i++)
        {
            if (i != id)
            {
                imageTargets[i].OnTrackableStateChanged(TrackableBehaviour.Status.NOT_FOUND, TrackableBehaviour.Status.NOT_FOUND);
            }
        }
    }
}
