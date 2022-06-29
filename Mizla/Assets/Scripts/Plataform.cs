using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public GameObject plataforma;
    public float velocidadPlataforma;
    //private Vector3 movimiento = new Vector3();
    //private float contador;
    public Transform posicionMa;
    public Transform posicionMi;
    

    private void OnTriggerStay(Collider other)
    {
       

        if(other != null)
        {
           
            MovePlataform();
        }
    }

    private void MovePlataform()
    {
       

        if (plataforma.transform.position.y >= posicionMa.position.y)
        {
            velocidadPlataforma *= -1;
        }
        if (plataforma.transform.position.y <= posicionMi.position.y)
        {
            velocidadPlataforma = Mathf.Abs(velocidadPlataforma);
        }

        plataforma.transform.Translate(Vector3.up*velocidadPlataforma*Time.deltaTime);
       
    }
}
