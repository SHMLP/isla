using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Animator animator;

    public void OpenDoor()
    {
        Debug.Log("sdasd");
        if (animator.GetBool("Abrepuerta")==false)
        {
            animator.SetTrigger("Abrepuerta");
        }
        if (animator.GetBool("Cierrapuerta") == false)
        {
            animator.SetTrigger("Cierrapuerta");
        }
    }

}
