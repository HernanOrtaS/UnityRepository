using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruye_Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject g = collision.gameObject;

        if (g.CompareTag("Item"))
        {
            //Destroy(g, 3f); //destruye el objeto 3 segs despues de tocarlo
            Destroy(g); //destruye inmediatamente
        }



    }


}