using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    [Range(0,100)]public float speedMovement;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(transform.forward*Time.deltaTime*speedMovement);
        }
        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(transform.forward * Time.deltaTime * -speedMovement);
        }

    }
}
