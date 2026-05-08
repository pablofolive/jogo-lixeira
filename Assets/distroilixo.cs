using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class distroilixo : MonoBehaviour
{
    public lixospawnercontroller pontuacao;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            Destroy(collision.gameObject);
            if (pontuacao.points > 0) {
                pontuacao.AddToPoints(-1);
            }
            
        }
    }
}
