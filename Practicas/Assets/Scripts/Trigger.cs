using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string nombre = other.gameObject.name;
        Debug.Log("Entra en trigger con: " + nombre);

        // Comprueba si el objeto que entró en el trigger tiene un Rigidbody
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Teletransporta el objeto a la posición (0, 5, 0)
            rb.transform.position = new Vector3(0f, 5f, 0f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        string nombre = other.gameObject.name;
        Debug.Log("En trigger con: " + nombre);
    }

    private void OnTriggerExit(Collider other)
    {
        string nombre = other.gameObject.name;
        Debug.Log("Sale de trigger con: " + nombre);
    }
}
