using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificaTrigger : MonoBehaviour
{
    // Start is called before the first frame update
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
