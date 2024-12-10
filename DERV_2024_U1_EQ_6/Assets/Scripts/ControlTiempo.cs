using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ControlTiempo : MonoBehaviour
{
    float contador_tiempo;
    float contador_segundos;

    [SerializeField] TextMeshProUGUI TextoTiempo;

    // Start is called before the first frame update
    void Start()
    {
        contador_tiempo = 0;
        contador_segundos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        contador_tiempo += Time.deltaTime;

        if (contador_tiempo > 1.0f) // Usa 'f' para indicar que es un valor float
        {
            TextoTiempo.text = contador_segundos.ToString();
            contador_segundos++;
            contador_tiempo = 0;
        }
    }
}
