using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distroilixo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            Destroy(collision.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
