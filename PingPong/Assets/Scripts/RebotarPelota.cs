using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebotarPelota : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int speed = 10;
    [SerializeField] string dirActual = "";
    string[] Direcciones = {"Arr-Der", "Der-Aba", "Aba-Izq", "Izq-Arr" };
    bool Colisiona = false;
    bool fueJugador = false;
    [SerializeField] private AudioSource playerHit;
    [SerializeField] private AudioSource wallHit;

    void Start()
    {
        dirActual = Direcciones[Random.Range(0, Direcciones.Length)];
    }

    // Update is called once per frame
    void Update()
    {   
        if (Colisiona) 
        {
            switch (dirActual) 
            {
                case "Arr-Der":
                    if (!fueJugador)
                    {
                        dirActual = "Der-Aba";
                        Colisiona = false;
                    }
                    else
                    {
                        dirActual = "Izq-Arr";
                        Colisiona = false;
                    }
                        
                    break;

                case "Der-Aba":
                    if (fueJugador)
                    {
                        dirActual = "Aba-Izq";
                        Colisiona = false;
                    }
                    else
                    {
                        dirActual = "Arr-Der";
                        Colisiona = false;
                    }
                        
                    break;

                case "Aba-Izq":
                    if (!fueJugador)
                    {
                        dirActual = "Izq-Arr";
                        Colisiona = false;
                    }
                    else
                    {
                        dirActual = "Der-Aba";
                        Colisiona = false;
                    }
                        
                    break;

                case "Izq-Arr":
                    if (fueJugador)
                    {
                        dirActual = "Arr-Der";
                        Colisiona = false;
                    }
                    else
                    {
                        dirActual = "Aba-Izq";
                        Colisiona = false;
                    }
                        
                    break;
            }
        }
        else
        {
            switch (dirActual)
            {
                case "Arr-Der":
                    Arr_Der();
                    break;

                case "Der-Aba":
                    Der_Aba();
                    break;

                case "Aba-Izq":
                    Aba_Izq();
                    break;

                case "Izq-Arr":
                    Izq_Arr();
                    break;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // Se ejecuta cuando el objeto comienza a colisionar
        Colisiona = true;
        if (collision.gameObject.CompareTag("Jugador"))
        {
            fueJugador = true;
            playerHit.Play();
        }
        else
        {
            fueJugador = false;
            wallHit.Play();
        }
    }

    private void Arr_Der()
    {
        transform.Translate(transform.TransformDirection(Vector3.up + Vector3.right) * speed * Time.deltaTime);
    }

    private void Der_Aba()
    {
        transform.Translate(transform.TransformDirection((Vector3.up * (-1)) + Vector3.right) * speed * Time.deltaTime);
    }

    private void Aba_Izq()
    {
        transform.Translate(transform.TransformDirection((Vector3.up * (-1)) + (Vector3.right * (-1))) * speed * Time.deltaTime);
    }

    private void Izq_Arr()
    {
        transform.Translate(transform.TransformDirection(Vector3.up + (Vector3.right) * (-1)) * speed * Time.deltaTime);
    }
}
