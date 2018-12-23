using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR;

public class appMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.Stationary);
        InputTracking.disablePositionalTracking = true;
        InputTracking.Recenter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
