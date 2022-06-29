using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdas : MonoBehaviour
{
    public GameObject plataforma;
    public float velocidadPlataforma;
    private Vector3 movimiento = new Vector3();
    private float contador;
    public float rango;
    //public Transform posicionMa;
    //public Transform posicionMi;
    //private bool a;

    private void OnTriggerStay(Collider other)
    {


        if (other != null)
        {
            //contador = 0;
            MovePlataform();
        }
    }

    private void MovePlataform()
    {

        movimiento.y = Mathf.Sin(Time.time)*rango;
        //print(movimiento.y);
        print(contador);
        plataforma.transform.position += movimiento;
        contador += 0.1f ;


    }
}

