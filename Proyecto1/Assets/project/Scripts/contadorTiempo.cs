using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class contadorTiempo : MonoBehaviour
{
    public TextMeshProUGUI mostrarTiempo;

    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("aumentaContador", 1f, 1f);
    }

    void aumentaContador()
    {
        contador++;
        mostrarTiempo.text = "Time: " + contador.ToString("D3");
    }
}
