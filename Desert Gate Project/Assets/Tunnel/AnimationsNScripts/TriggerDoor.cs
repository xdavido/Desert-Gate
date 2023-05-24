using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] private Animator DoorLeft = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "DoorOpen";
    [SerializeField] private string doorClose = "DoorClose";

    private void OnTriggerEnter(Collider other)
    {
        if(openTrigger)
        {
            DoorLeft.Play("DoorOpen", 0, 0.0f);
            gameObject.SetActive(false);
        }
        else if (closeTrigger)
        {
            DoorLeft.Play("DoorClose", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }
}
