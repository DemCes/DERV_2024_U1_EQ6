using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class S7_ControlTiempoConCorutina : MonoBehaviour
{
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Texto_Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        contador_segundos = 0;
        StartCoroutine(corrutinaTiempo()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator corrutinaTiempo() 
    {
        while (true)
        {
            Texto_Tiempo.text = contador_segundos++.ToString(); // Actualiza el texto cada 1/4 de segundo
            yield return new WaitForSeconds(0.25f); // Espera 1/4 de segundo
        }
    }
}
