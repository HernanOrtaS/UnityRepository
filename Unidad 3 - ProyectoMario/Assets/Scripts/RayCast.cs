using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 inicioRayo = transform.position;
        inicioRayo.y -= 0.75f;


        RaycastHit hit; //almacena la informacion del objeto con el que choque el
        bool detectacObjeto = Physics.Raycast(inicioRayo, transform.forward, out hit, 4f);
        // Physics.Raycast(inicioRayo, transform.forward * 4f, out hit);


        if (detectacObjeto)
        {
            Debug.DrawRay(inicioRayo, transform.forward * hit.distance, Color.red);
        }
        else {
            Debug.DrawRay(inicioRayo, transform.forward * 4f, Color.yellow);
        }


    }
}
