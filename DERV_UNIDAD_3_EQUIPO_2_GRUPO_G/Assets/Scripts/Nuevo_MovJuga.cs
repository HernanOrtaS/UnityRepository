using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuevo_MovJuga : MonoBehaviour
{
    public float velocidadMovimiento = 15f; // Velocidad de movimiento del personaje.

    void Update()
    {
        // Movimiento hacia arriba (W) Angulo correcto = 0°
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }

        // Movimiento hacia abajo (S) Angulo correcto = 180°
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }

        // Movimiento hacia la izquierda (A) Angulo correcto = 270°
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }

        // Movimiento hacia la derecha (D) Angulo correcto = 90°
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }
    }
}

