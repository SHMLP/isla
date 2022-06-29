using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject prefab_bullet;
    public Transform spawnPoint;
    public float incremento;
    public Transform posicion;
  
   
     
    public void CogerArma(Transform tomar)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        posicion.parent = tomar;
        posicion.position = tomar.position;
        posicion.rotation = tomar.rotation;
        GetComponent<Transform>().position = posicion.position;
    }
    public void GuardarArma(ref LayerMask capa)
    {
        if (GetComponent<BoxCollider>().enabled == false)
        {
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<Renderer>().enabled = true;
            capa = LayerMask.GetMask("Default");
        }
        else
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
            capa = LayerMask.GetMask("Interactable");
        }

    }

    public void Update()
    {
        if (GetComponent<BoxCollider>().enabled == true && transform.name== "Gren" && Input.GetButtonDown("Fire1") && posicion.parent != null)
        {
            ShootBullet();
        }
        if (GetComponent<BoxCollider>().enabled == true && transform.name == "LaserGun" && Input.GetButtonDown("Fire1") && posicion.parent != null)
        {
            ShootRay();
        }
    }

    void ShootBullet()
    {
        GameObject go = Instantiate(prefab_bullet, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = go.GetComponent<Rigidbody>();
        rb.AddForce(go.transform.forward*incremento,ForceMode.Impulse);
    }

    void ShootRay()
    {
        if(Physics.Raycast(FindObjectOfType<Camera>().transform.position, FindObjectOfType<Camera>().transform.forward,out RaycastHit hit,incremento))
        {
           
            if (hit.transform.tag == "Enemy")
            {
                Debug.Log(hit.transform.name);
            }

        }
    }
}
