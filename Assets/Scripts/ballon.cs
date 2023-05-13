using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class ballon : MonoBehaviour
{
    // Start is called before the first frame update
    private Grabbable gb;
    private Rigidbody rb;

    void Start()
    {
                rb = GetComponent<Rigidbody>();
        gb = GetComponent<Grabbable>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb != null)
        {
            // Obtener todas las fuerzas que se están aplicando al Rigidbody

            float velocityMagnitude = Vector3.Dot(rb.velocity, transform.forward);

            Vector3 velocity = rb.velocity;

            Debug.Log(velocityMagnitude);

            if (velocityMagnitude > 1f)
            {

                if (velocityMagnitude < 2.2)
                {
                    float factor = 1.2f;
                    Vector3 newVelocity = velocity * factor;

                    // Asignar la nueva velocidad al Rigidbody
                    rb.velocity = newVelocity;
                }
            }
        }

        var posicion = transform.position;


        if (posicion.z < -8)
        {
            transform.position = new Vector3(0, 0.5f, 0);
            rb.velocity = new Vector3(0, 0, 0);
        }
        

    }
}
