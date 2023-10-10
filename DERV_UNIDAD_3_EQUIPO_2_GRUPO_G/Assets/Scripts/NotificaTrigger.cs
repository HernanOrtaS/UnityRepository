using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificaTrigger : MonoBehaviour
{
    public bool detectaJugador;
    private void OnTriggerEnter(Collider other)
    {
        detectaJugador = true;
    }
    private void OnTriggerExit(Collider other)
    {
        detectaJugador = false;
    }
}