using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteration : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")
        {
            
            other.GetComponentInParent<Puerta>().OpenDoor();

        }

    }
}