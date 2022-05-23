using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float maxLife = 100;
    private float courrentLife;

    public float CourrentLife
    {
        get
        {
            return courrentLife;
        }
    }
    private void Start()
    {
        courrentLife = maxLife;
    }

    public void GetDamage(float damage)
    {
        
        courrentLife -= damage;
        

        if (courrentLife <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    

}
