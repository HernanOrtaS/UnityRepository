using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaBala : MonoBehaviour
{
    private void Start()
    {
        Invoke("desaparece", 1f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }

    void desaparece()
    {
        Destroy(gameObject);
    }
}
