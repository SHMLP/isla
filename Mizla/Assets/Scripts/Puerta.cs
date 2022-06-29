using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Animator animator;


    public void OpenDoor()
    {
       
        if (animator.GetBool("Abrepuerta") == false)
        {
            
            animator.SetTrigger("Abrepuerta");
        }
        else 
        {
            
            animator.SetTrigger("Cierrapuerta");
        }
        
    }

}
