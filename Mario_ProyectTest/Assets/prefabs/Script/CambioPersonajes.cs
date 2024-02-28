using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CambioPersonajes : MonoBehaviour
{
    public List<Personaje> personajes;
    GameObject managerConversacion;
    HandlerConversacion handlerConv;
    [SerializeField] int indexPersonaje;

    [SerializeField] GameObject imagenPersonaje;
    [SerializeField] GameObject nombrePersonaje;
    Image ingP;
    TextMeshProUGUI textNombre;
    // Start is called before the first frame update
    void Start()
    {
        indexPersonaje = -1;
        managerConversacion = GameObject.Find("ManagerConversacion");
        handlerConv = managerConversacion.GetComponent<HandlerConversacion>();

        ingP = imagenPersonaje.GetComponent<Image>();
        textNombre = nombrePersonaje.GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (handlerConv.estadoPanel)
            {
                indexPersonaje++;
                ingP.sprite = personajes[Mathf.Abs(indexPersonaje)].imagen;
                textNombre.text = personajes[Mathf.Abs(indexPersonaje)].nombre;
                if (indexPersonaje == 4)
                {
                    indexPersonaje = -indexPersonaje;
                }
            }
        }
    }
}
