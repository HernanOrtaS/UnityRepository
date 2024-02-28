using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform jugador; // Referencia al objeto del jugador
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Ajuste de posición de la cámara


    void Update()
    {
        if (jugador != null)
        {
            // Actualizar la posición de la cámara para seguir al jugador con un desplazamiento dado
            transform.position = jugador.position + offset;
        }
    }
}
