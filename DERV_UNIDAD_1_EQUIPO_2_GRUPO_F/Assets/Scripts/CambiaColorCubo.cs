using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorCubo : MonoBehaviour
{
    // Start is called before the first frame update
    public int index = 8;

    [SerializeField] 
    Color tonalidad1;
    [SerializeField]
    Color tonalidad2;
    [SerializeField]
    Color tonalidad3;

    [SerializeField]
    Renderer paper1;
    [SerializeField]
    Renderer paper2;
    [SerializeField] 
    Renderer paper3; //Se asocia por getcomponent

    [SerializeField]
    GameObject fig1;
    [SerializeField]
    GameObject fig2;
    [SerializeField]
    GameObject fig3; //Se asocia por inspector
    
    void Start()
    {
        paper1 = fig1.GetComponent<Renderer>();
        paper2 = fig2.GetComponent<Renderer>();
        paper3 = fig3.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            Debug.Log("Pulsaste la tecla R");
        }

        if (Input.GetKeyDown(KeyCode.G)){
            Debug.Log("Pulsaste la tecla G");
        }

        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log("Pulsaste la tecla B");
        }
        paper1.material.color = tonalidad1;
        paper2.material.color = tonalidad2;
        paper3.material.color = tonalidad3;
    }
}
