using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    LookAt objlookAt; 

    //No olvidar definir en el inspector
    [SerializeField] GameObject jugador;
    [SerializeField] float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        objlookAt = GetComponent<LookAt>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (objlookAt.JugadorEnLaMira)
        {
            //Calcular la distancia del enemigo al jugador
            float distancia = Vector3.Distance(
                transform.position,
                jugador.transform.position
                );
            Debug.Log("Distancia: " + distancia);


            if (distancia > 2.5)
            {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    jugador.transform.position,
                    velocidad * Time.deltaTime
                    );

            }

        }
    }

}
