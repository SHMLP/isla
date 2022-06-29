using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("movimiento personaje")]
    public float speedMovement;
    public Vector3 direccion;
    public CharacterController controller;
    public Vector3 velocidad;
    private float altura = 2f;
    private float rotarPersonaje;
    private float correr=1f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        correr = 1f;
        if (controller.isGrounded == false)
        {
            velocidad.y += -9.8f * Time.deltaTime;
        }
    }
    public void Run()
    {
        if (controller.isGrounded)
        {
            correr = 2f;
        }
    }
    public void Move(float horizontal,float vertical)
    {      
        direccion = new Vector3(horizontal, velocidad.y / speedMovement, vertical);
        direccion.z = direccion.z * correr;
        controller.Move(transform.TransformDirection(direccion) * speedMovement * Time.deltaTime);
    }

    public void RotarPersonaje(float rotacionPersonaje)
    {
        rotarPersonaje += rotacionPersonaje;
        controller.transform.rotation = Quaternion.Euler(0, rotarPersonaje, 0);
    }

    public void Saltar()
    {
        if (controller.isGrounded)
        {
            velocidad.y = Mathf.Sqrt(altura * 2 * 9.8f);
        }
       
    }
}