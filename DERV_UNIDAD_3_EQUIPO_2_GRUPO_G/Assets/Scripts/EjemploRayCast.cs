using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploRayCast : MonoBehaviour
{
    Transform obj_a_mirar;

    // Start is called before the first frame update
    void Start()
    {
        obj_a_mirar = GameObject.Find("Jugador").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 destino = obj_a_mirar.position;

        RaycastHit hit; //almacena la información de colisión del rayo
        bool estado = Physics.Raycast(origen, transform.forward, out hit, 10);

        if (estado)
        {
            Debug.Log(hit.distance);
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawRay(origen, transform.forward * hit.distance, Color.yellow);
        }
        else
        {
            Debug.DrawRay(origen, transform.forward * 10, Color.yellow);
        }
    }
}
