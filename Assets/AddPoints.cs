using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
   
   public lixospawnercontroller lixoSpawnerController;

   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            Destroy(collision.gameObject);
            lixoSpawnerController.AddToPoints(1);
        }
    }
    


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
