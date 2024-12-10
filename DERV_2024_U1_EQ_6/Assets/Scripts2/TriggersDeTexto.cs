using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersDeTexto : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("T. Enter -" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("T. Stay -" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
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
