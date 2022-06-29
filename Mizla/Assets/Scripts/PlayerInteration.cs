using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteration : MonoBehaviour
{
    public PlayerState playerState;
    public Transform cameraPlayer,tomarObj,tomarArm;
    public float distance;
    public LayerMask capas;

   
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Interaction") && other.tag == "Door" && playerState.bateryCount == 4)
        {
            other.GetComponentInParent<Puerta>().OpenDoor();
        }
        if (other.tag == "Baterie")
        {
            other.GetComponentInParent<Bateria>().Desaparece();
            playerState.bateryCount++;
        }
        if (other.tag == "Gun" && Input.GetKeyDown(KeyCode.E))
        {
            
            other.GetComponentInParent<Gun>().CogerArma(tomarArm);
            other.GetComponent<BoxCollider>().enabled = false;
            capas = LayerMask.GetMask("Default");
        }
    }

    private void Update()
    {

        if (tomarArm.childCount != 0 && Input.GetKeyDown(KeyCode.G) && tomarObj.childCount == 0)
            tomarArm.GetComponentInChildren<Gun>().GuardarArma(ref capas);
        Debug.DrawRay(cameraPlayer.position, cameraPlayer.forward * 10f, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(cameraPlayer.position,cameraPlayer.forward,out hit,distance,capas) && capas == LayerMask.GetMask("Interactable"))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Box")
                    CogerObjeto(hit, tomarObj);
               
            }
        }
        else if (tomarObj.childCount != 0 && Input.GetButtonDown("Fire1"))
            SoltarObjeto(tomarObj);
        
       


        void CogerObjeto(RaycastHit hit, Transform coger)
        {
          
            hit.transform.parent = coger;
            hit.transform.GetComponent<Rigidbody>().isKinematic = true;
            hit.transform.position = coger.position;
            capas = LayerMask.GetMask("Default");

        }

        void SoltarObjeto(Transform coger)
        {
            coger.GetComponentInChildren<Rigidbody>().isKinematic = false;
            coger.transform.DetachChildren();
            capas = LayerMask.GetMask("Interactable");
        }
       

    }



}