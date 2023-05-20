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
        transform.position = new Vector3(x, y, -4.66f);
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
            transform.position = new Vector3(x,y,-4.33f);

            logica.puntuacion += 100;

            balon.transform.position = new Vector3(0, 0.9f, -0.313f);
            balon.rb.velocity = new Vector3(0, 0, 0);
            balon.rb.angularVelocity = Vector3.zero;

        }
    }
}
