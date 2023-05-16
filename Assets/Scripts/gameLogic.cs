using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    // Start is called before the first frame update

    public double puntuacion;
    public Text texto;
    void Start()
    {
        puntuacion = 0;   
    }

    // Update is called once per frame
    void Update()
    {

        texto.text = "Puntuación= " + puntuacion.ToString();

        if(puntuacion >= 1000)
        {
            Debug.Log("Has ganado");
        }
    }
}
