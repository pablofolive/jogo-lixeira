using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraController : MonoBehaviour
{
    public float velocity;

void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        this.transform.position += new Vector3(horizontalInput * velocity, 0, 0);

        if (this.transform.position.x > 11)
        {
            this.transform.position = new Vector3(11, this.transform.position.y, this.transform.position.z);
        }
        else if (this.transform.position.x < -11)
        {
            this.transform.position = new Vector3(-11, this.transform.position.y, this.transform.position.z);
        }
    }
}