using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class ballon : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public bool onTable = true;
    public bool onFloor = false;
    public AudioSource audioPalo;

    void Start()
    {
                rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //if (rb != null)
        //{
        //    // Obtener todas las fuerzas que se están aplicando al Rigidbody

        //    float velocityMagnitude = Vector3.Dot(rb.velocity, transform.forward);

        //    Vector3 velocity = rb.velocity;

        //    Debug.Log(velocityMagnitude);

        //    if (velocityMagnitude > 1f)
        //    {

        //        if (velocityMagnitude < 2.2)
        //        {
        //            float factor = 1.2f;
        //            Vector3 newVelocity = velocity * factor;

        //            // Asignar la nueva velocidad al Rigidbody
        //            rb.velocity = newVelocity;
        //        }
        //    }
        //}

        var posicion = transform.position;


        if (posicion.z < -8)
        {
            transform.position = new Vector3(0, 0.9f, -0.313f);
            rb.velocity = new Vector3(0, 0, 0);
            onFloor = true;

            rb.angularVelocity = Vector3.zero;
        }
        

    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mesa"))
        {
            onTable = true;
        }
            if (other.CompareTag("floor"))
        {
            yield return new WaitForSeconds(1.5f);
            transform.position = new Vector3(0, 0.9f, -0.313f);
            rb.velocity = new Vector3(0, 0, 0);
            rb.angularVelocity = Vector3.zero;
            onFloor = true;

        }

        if (other.CompareTag("palo"))
        {
            audioPalo.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("mesa"))
        {
            onTable = false;

        }
        if (other.CompareTag("floor"))
        {
            onFloor = false;

        }
    }


}
