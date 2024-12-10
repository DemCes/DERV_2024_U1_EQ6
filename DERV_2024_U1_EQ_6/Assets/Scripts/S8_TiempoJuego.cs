using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class S8_TiempoJuego : MonoBehaviour
{
    [SerializeField] CambioEscena1 auxiliar;
    [SerializeField] DestruyeObjetosReporta acceso_score;

    int contador_segundos;

    [SerializeField] TextMeshProUGUI Texto_Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        contador_segundos = 60;
        Texto_Tiempo.text = contador_segundos.ToString(); 
        contador_segundos--;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator corrutinaTiempo()
    {
        while (contador_segundos > 0)
        {
            Texto_Tiempo.text = contador_segundos.ToString();
            contador_segundos--;
            yield return new WaitForSeconds(0.25f); // Cada 1/4 de segundo
        }

        Debug.Log("Juego Terminado");
        int score = acceso_score.contador_enemigos;
        auxiliar.cambioDeEscena1(2, score); // Cambia a la escena de Fin con el score
    }
}
//The type or namespace name "SceneChange" could not be found (are you missing a using directive or an assembly reference?)