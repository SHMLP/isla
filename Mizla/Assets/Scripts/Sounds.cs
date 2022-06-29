using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
   public AudioSource reproductorSonido;
   public void Reproductor(AudioSource audio)
   {
        reproductorSonido = audio;
        Debug.Log(reproductorSonido.clip);
        reproductorSonido.Play(0);
        
   }
}
