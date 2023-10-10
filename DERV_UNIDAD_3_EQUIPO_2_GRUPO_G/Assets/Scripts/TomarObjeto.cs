using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarObjeto : MonoBehaviour
{   
    Transform IniciaRayo;

    // Start is called before the first frame update
    void Start()
    {
        IniciaRayo = GameObject.Find("Rayo").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = IniciaRayo.position;

        RaycastHit hit; //Almacena información

        bool estado = Physics.Raycast(origen, transform.forward, out hit, 10);

        if (estado)
        {
            //Debug.Log(hit.distance)
            float d = hit.distance;
            Debug.Log(hit.collider.gameObject.name + " - " + d.ToString());
            Debug.DrawRay(origen, transform.forward * hit.distance, Color.green);

            if (d < 1.0f)
            {
                //Tomar objeto
                GameObject obj = hit.collider.gameObject;
                obj.transform.SetParent(transform);

                GameObject objPosDestino = GameObject.Find("PosicionManos");
                obj.transform.position = objPosDestino.transform.position;
                obj.transform.rotation = objPosDestino.transform.rotation;
                obj.transform.localScale = objPosDestino.transform.localScale;
            }
        }
        else
        {
            Debug.DrawRay(origen, transform.forward * 10, Color.cyan);
        }

    }
}