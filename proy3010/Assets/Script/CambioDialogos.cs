using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CambioDialogos : MonoBehaviour
{
    public List<PersDialogo> personajes;

    GameObject managerConversacion;
    [SerializeField] int indexPersonaje;

    [SerializeField] GameObject imagenPersonaje;
    [SerializeField] GameObject nombrePersonaje;
    [SerializeField] GameObject dialogoPersonaje;

    Image ingP;
    TextMeshProUGUI textNombre;
    TextMeshProUGUI dialogo;
    // Start is called before the first frame update
    void Start()
    {
        indexPersonaje = -1;
        managerConversacion = GameObject.Find("ManagerConversacion");

        ingP = imagenPersonaje.GetComponent<Image>();
        textNombre = nombrePersonaje.GetComponent <TextMeshProUGUI>();
        dialogo = dialogoPersonaje.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            indexPersonaje++;
            ingP.sprite = personajes[Mathf.Abs(indexPersonaje)].imagen;
            textNombre.text = personajes[Mathf.Abs(indexPersonaje)].nombre;
            StopAllCoroutines();
            StartCoroutine(textoDelay(personajes[Mathf.Abs(indexPersonaje)].dialog));
            if (indexPersonaje == personajes.Count-1)
            {
                indexPersonaje= -indexPersonaje;
            }
        }
    }
    IEnumerator textoDelay(string texto)
    {
        List<char> caracteres = new List<char>();

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres.Add(texto[i]);
            dialogo.text = new string(caracteres.ToArray());
            yield return new WaitForSeconds(personajes[Mathf.Abs(indexPersonaje)].velTexto);
        }
    }
}
