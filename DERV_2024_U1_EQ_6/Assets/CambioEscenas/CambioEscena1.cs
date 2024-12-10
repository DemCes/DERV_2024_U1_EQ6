using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class CambioEscena1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_score;

    private void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex; // 0, 1, 2

        if (escena_actual == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cambioDeEscena1(1);
            }
        }
        else if (escena_actual == 2)
        {
            texto_score.text = PlayerPrefs.GetInt("Score", 0).ToString();
        }
    }

    public void cambioDeEscena1(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void cambioDeEscena1(int index_escena_ir, int score)
    {
        PlayerPrefs.SetInt("Score", score);
        cambioDeEscena1(index_escena_ir); // Llamada correcta al método
    }
} //The namespace <global namespace> already contains a definition for CambioEscena
