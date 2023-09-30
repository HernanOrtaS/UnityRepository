using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    [SerializeField] Transform jugador;
    [SerializeField] float velocidad;
    [SerializeField] NotificaTrigger notifica;
    
    
    void Start()
    {
        jugador = GameObject.Find("Jugador").transform;
        notifica = GetComponentInChildren <NotificaTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (notifica.detectaJugador) 
        {
            float distancia = Vector3.Distance(transform.position, jugador.position);
            if (distancia > 2)
            {
                transform.position = Vector3.MoveTowards(transform.position,
                jugador.position, velocidad * Time.deltaTime);
            }
            
        }
    }
}
