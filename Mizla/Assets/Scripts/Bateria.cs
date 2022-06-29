using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{

    public AudioSource audi;
    //public GameObject obj;
    public void Desaparece()
    {
        audi.Play(0);
        GetComponent<Renderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
    }
   
}
