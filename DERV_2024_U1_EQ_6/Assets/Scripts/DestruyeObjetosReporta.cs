using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class DestruyeObjetosReporta : MonoBehaviour
{
    public int contador_enemigos;

    [SerializeField] TextMeshProUGUI Texto_Enemigos;

    // Start is called before the first frame update
    void Start()
    {
        contador_enemigos = 0;
    }

    // Este método se llama cuando ocurre una colisión
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            GameObject obj = other.gameObject;
            Destroy(obj); 
            contador_enemigos++; 
            Texto_Enemigos.text = contador_enemigos.ToString(); 
        }
    }
}

