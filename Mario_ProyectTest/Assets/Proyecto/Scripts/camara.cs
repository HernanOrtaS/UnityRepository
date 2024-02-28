using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform jugador; // Referencia al objeto del jugador
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Ajuste de posici�n de la c�mara


    void Update()
    {
        if (jugador != null)
        {
            // Actualizar la posici�n de la c�mara para seguir al jugador con un desplazamiento dado
            transform.position = jugador.position + offset;
        }
    }
}
