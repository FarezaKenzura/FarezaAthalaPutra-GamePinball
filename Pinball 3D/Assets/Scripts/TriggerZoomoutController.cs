using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomoutController : MonoBehaviour
{
    public CameraController cameraController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            cameraController.GoBackToDefault();
        }
    }
}
