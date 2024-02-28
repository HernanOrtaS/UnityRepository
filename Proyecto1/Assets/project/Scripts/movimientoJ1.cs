using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJ1 : MonoBehaviour
{
    bool Saltar = true;

    public float Caminar = 5.0f;
    public float Correr = 10.0f;
    float velHorizontal = 0;

    float movHorizontal = 0f;
    float movVertical = 0f;

    Rigidbody rb;
    Animator animador;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animador = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = 0f;
        movVertical = 0f;

        if (Input.GetKey(KeyCode.V))
        {
            velHorizontal = Correr;
        }
        else
        {
            velHorizontal = Caminar;
        }

        if  (Input.GetKey(KeyCode.W)) 
        {
            movVertical = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movVertical = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movHorizontal = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movHorizontal = -1;
        }

        Vector3 movimiento = new Vector3(movHorizontal, 0, movVertical) * velHorizontal * Time.deltaTime;
        transform.position += movimiento;

        if (movimiento != Vector3.zero) 
        {
            Quaternion rotacion = Quaternion.LookRotation(movimiento);
            transform.rotation = rotacion;
        }

        if (movHorizontal == 0 && movVertical == 0)
        {
            animador.SetFloat("Movimiento", 0);
        }
        else 
        {
            animador.SetFloat("Movimiento", velHorizontal / 5);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Saltar)
        {
            RaycastHit tocandoSuelo;
            float distanciaRaycast = 1.5f;
            if ((Physics.Raycast(transform.position, Vector3.down, out tocandoSuelo, distanciaRaycast)))
            {   
                rb.AddForce(Vector3.up * 7, ForceMode.Impulse);
                Saltar = false;
            }
        }
        if (!Saltar)
        {
            animador.SetFloat("Movimiento", 3);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Saltar = true;
            animador.SetFloat("Movimiento", 0);
        }
    }
}
