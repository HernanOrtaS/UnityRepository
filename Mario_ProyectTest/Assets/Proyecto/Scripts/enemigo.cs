using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    float velocidad = 3.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si colisiona ejecuta una vuelta
        if (collision.gameObject.CompareTag("Pared"))
        {
            rb.AddForce(Vector3.up * 3, ForceMode.Impulse);
            transform.Rotate(0f, 180f, 0f);
        }
        
    }
}
