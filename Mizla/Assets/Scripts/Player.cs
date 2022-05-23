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


    [Header("movimiento camara")]
    public Camera camara;
    public Vector2 direccionCamara;
    private float posicionCamaraY;
    private float posicionCamaraX;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;


    }

    void Update()
    {

        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            velocidad.y = Mathf.Sqrt(altura * 2 * 9.8f);
        }
        if (controller.isGrounded == false)
        {
            velocidad.y += -9.8f * Time.deltaTime;
        }

        direccion = new Vector3(Input.GetAxis("Horizontal"), velocidad.y / speedMovement, Input.GetAxis("Vertical"));
        direccionCamara = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        if (controller.isGrounded && Input.GetButton("Run"))
        {

            direccion.z = direccion.z * 2;
        }


        posicionCamaraY += direccionCamara.y;
        posicionCamaraX += direccionCamara.x;

        posicionCamaraY = Mathf.Clamp(posicionCamaraY, -90, 90);

        camara.transform.localRotation = Quaternion.Euler(-posicionCamaraY, 0, 0);
        controller.transform.rotation = Quaternion.Euler(0, posicionCamaraX, 0);


        controller.Move(transform.TransformDirection(direccion) * speedMovement * Time.deltaTime);

    }


}