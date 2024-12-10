using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyeObjetos : MonoBehaviour
{
    // OnCollisionEnter is called when the object collides with another object
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            GameObject obj = other.gameObject; 
            Destroy(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

