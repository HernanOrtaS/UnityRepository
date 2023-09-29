using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer objetoRenderer;
    private Material materialObjeto;
    public int RGB_R = 0;
    public int RGB_G = 0;
    public int RGB_B = 0;

    void Start()
    {
        // Obtén el componente Renderer del objeto
        objetoRenderer = GetComponent<Renderer>();

        // Obtén el material del objeto
        materialObjeto = objetoRenderer.material;
    }

    void Update()
    {
        // Detecta la tecla "R" y cambia el color a rojo
        if (Input.GetKey(KeyCode.R))
        {
            RGB_R += 3;
            if (RGB_R >= 256){
                RGB_R = -RGB_R;
            }
        }

        // Detecta la tecla "G" y cambia el color a verde
        if (Input.GetKey(KeyCode.G))
        {
            RGB_G += 3;
            if (RGB_G >= 256){
                RGB_G = -RGB_G;
            }
        }

        // Detecta la tecla "B" y cambia el color a verde
        if (Input.GetKey(KeyCode.B))
        {
            RGB_B += 3;
            if (RGB_B >= 256){
                RGB_B = -RGB_B;
            }
        }
        materialObjeto.color = (new Color(Mathf.Abs(RGB_R) / 255f, Mathf.Abs(RGB_G) / 255f, Mathf.Abs(RGB_B) / 255f));
    }
}
