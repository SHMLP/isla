using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public float damageArea; 
    public float damage;
    public Enemigo[] enemigos;
    private int indice = 0;


    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.transform.name);
        
        while (indice < enemigos.Length)
        {
            if (Vector3.Distance(enemigos[indice].transform.position, transform.position) <= damageArea)
            {
                enemigos[indice].GetDamage(damage);
                Debug.Log(enemigos[indice].CourrentLife);
            }
            indice++;
        }
        indice = 0;
        
    }


}
