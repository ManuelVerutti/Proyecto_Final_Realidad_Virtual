using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    // Start is called before the first frame update

    public gameLogic logica;
    public ballon balon;

    void Start()
    {
        var x = Random.Range(-1.5f, 2f);
        var y = Random.Range(0.35f, 1.57f);
        transform.position = new Vector3(x, y, -7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("balon"))
        {

            var x = Random.Range(-1.5f, 2f); 
            var y = Random.Range(0.35f, 1.57f);
            transform.position = new Vector3(x,y,-3.3f);

            logica.puntuacion += 100;

            balon.transform.position = new Vector3(0, 0.5f, 0);
            balon.rb.velocity = new Vector3(0, 0, 0);

        }
    }
}
