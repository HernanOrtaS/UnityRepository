using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorrido : MonoBehaviour
{
    LookAt objlookAt;

    //punto1 punto2 punto3 punto4
    [SerializeField] List<GameObject> puntos; //puntos a los que ira el personaje
    int posActual = 0;

    // Start is called before the first frame update
    void Start()
    {
        objlookAt = GetComponent<LookAt>();
    }

    int sentido = 1;

    // Update is called once per frame
    void Update()
    {
        //si personaje no esta en la mira, entonces hace el recorrido predeterminado
        if (!objlookAt.JugadorEnLaMira)
        {
            if (Vector3.Distance(transform.position, puntos[posActual].transform.position) > 0.25f)
            {
                transform.position = Vector3.MoveTowards(transform.position,
                    puntos[posActual].transform.position,
                    24f * Time.deltaTime
                    );
            }
            else
            {
                //cuando llega al punto actual, entonces pasara al segundo punto
                if (posActual == 3)
                {
                    sentido = -1;
                }
                else if (posActual == 0)
                {
                    sentido = 1;
                }

                posActual += sentido;
            }
        }
        else {
         //aqui no hace nada, porque el enemigo esta persiguiendo al perosnaje       
        }


    }
}
