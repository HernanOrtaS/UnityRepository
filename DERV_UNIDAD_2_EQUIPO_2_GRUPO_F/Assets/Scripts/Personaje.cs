using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f; // Velocidad de movimiento del personaje

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = 0;
        float movimientoVertical = 0;

        if (Input.GetKey("w"))
        {
            movimientoVertical = 1f;
        }
        if (Input.GetKey("s"))
        {
            movimientoVertical = -1f;
        }
        if (Input.GetKey("a"))
        {
            movimientoHorizontal = -1f;
        }
        if (Input.GetKey("d"))
        {
            movimientoHorizontal = 1f;
        }

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical) * velocidadMovimiento;
        rb.velocity = movimiento;
    }
}
