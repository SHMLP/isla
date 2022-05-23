using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string _nombre,_apellido;

    public Prueba1()
    {
      
    }
    public Prueba1(string Nom)
    {
        _nombre = Nom;
        
    }
    public Prueba1(string Nom, string Apell)
    {
        _nombre = Nom;
        _apellido = Apell;
    }
    public void Saludo()
    {
        Debug.Log($"Hola");
    }

    public void Saludo(string Nom)
    {
        Debug.Log($"Hola, {Nom}");
        

    }
    public void Saludo(string Nom, string Apell)
    {
        Debug.Log($"Hola, {Nom} {Apell}");

    }


    // Update is called once per frame

}
