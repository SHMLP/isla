using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class EnemyController : MonoBehaviour
{
    public Transform jugador,vista;
    public float range, actackrange,giroEnemigo;
    private float tiempoDeAtaque;
    Player enemyMove;
    public Animator animacion;

    //public LayerMask ataqueEnemigo;


    private void Start()
    {
        enemyMove = GetComponent<Player>();
    }



    private void Update()
    {
        
        if (Vector3.Distance(transform.position, jugador.position) <= actackrange+1 && Vector3.Dot((jugador.position - transform.position).normalized, transform.TransformDirection(Vector3.forward).normalized) >= 0.5)
        //if (Physics.Raycast(vista.position,vista.forward,out RaycastHit hit,actackrange))
        {
            tiempoDeAtaque += Time.deltaTime;
            print("muere1");

       
            //if (hit.transform.name == "Jugador" )
            //{
                //print("muere2");
                enemyMove.Move(0, 0);
                animacion.SetFloat("SpeedMovement", 0);
                //print("tiempo"+tiempoDeAtaque);
                //print(Vector3.Distance(transform.position, jugador.position));
                if (tiempoDeAtaque >= 3f && Vector3.Distance(transform.position, jugador.position) <= actackrange+1)
                {
                    
                    print("muere3");
                   
                    animacion.SetFloat("Atacar", 1);
                    tiempoDeAtaque = 0;
                  

                }
            //}
           
        }
        else if (Vector3.Distance(transform.position, jugador.position) <= range)
        {
            
            if (Vector3.Dot((jugador.position - transform.position).normalized, transform.TransformDirection(Vector3.forward).normalized) >= 0.5)
            {
                tiempoDeAtaque = 0;
                animacion.SetFloat("Atacar", 0);
                animacion.SetFloat("SpeedMovement",1f);
                enemyMove.Move(0, 1);
                    
                if (Vector3.Dot((jugador.position - transform.position).normalized, transform.TransformDirection(Vector3.right).normalized) >= 0)
                {
                    enemyMove.RotarPersonaje(giroEnemigo*Mathf.Pow(((jugador.position - transform.position).normalized - transform.TransformDirection(Vector3.forward).normalized).magnitude, 10f));
                }
                else
                {
                    enemyMove.RotarPersonaje(-giroEnemigo * Mathf.Pow(((jugador.position - transform.position).normalized - transform.TransformDirection(Vector3.forward).normalized).magnitude, 10f));
                }
                
            }
        }
        else
        {
            animacion.SetFloat("SpeedMovement", 0.1f);
        }

    }
}
