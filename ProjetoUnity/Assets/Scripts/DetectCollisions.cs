using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            var pontos = FindObjectOfType<Pontos>();
            if(pontos!= null) pontos.MudarPontos();
        }
    }
}
