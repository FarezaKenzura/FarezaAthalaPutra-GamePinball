using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TriggerGameOver : MonoBehaviour
{
    public UnityEvent OnPlayerLose;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            OnPlayerLose.Invoke();
        }
    }
}
