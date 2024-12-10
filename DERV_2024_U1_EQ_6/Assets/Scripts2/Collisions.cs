using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("T. Enter -" + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("T. Stay -" + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("T. Exit -" + other.gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
