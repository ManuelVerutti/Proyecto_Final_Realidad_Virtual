using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interfaces : MonoBehaviour
{

    public GameObject[] losCanvas;
    public int interfazActual = 0;
    public ballon ballon;
    public bool finalizo = false;
    public gameLogic logica;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (interfazActual ==0)
        {
            yield return new WaitForSeconds(11);
            losCanvas[1].SetActive(true);
            losCanvas[0].SetActive(false);
            interfazActual = 1;
        }
        
    }


    // Update is called once per frame
    void Update()
    {

        if (interfazActual== 1 && !ballon.onTable)
        {
            losCanvas[2].SetActive(true);
            losCanvas[1].SetActive(false);

            interfazActual = 2;
        }
        if (interfazActual == 2 && ballon.onFloor)
        {
            losCanvas[3].SetActive(true);
            losCanvas[2].SetActive(false);

            interfazActual = 3;
        }
        if (interfazActual == 3 && !finalizo)
        {
            finalizo = true;
            StartCoroutine(IncrementarInterfazDespuesDeEspera());

        } 
        if(logica.puntuacion >= 1000)
        {
            losCanvas[5].SetActive(true);
            losCanvas[4].SetActive(false);

            interfazActual = 5;
        }

    }

    private IEnumerator IncrementarInterfazDespuesDeEspera()
    {
        yield return new WaitForSeconds(8);
        losCanvas[4].SetActive(true);
        losCanvas[3].SetActive(false);
        interfazActual = 4;
    }
}
