using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerSO_CambiaColor : MonoBehaviour
{
    [SerializeField]
    SO_CambiaColor color_so;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = color_so.c;
    }
}
