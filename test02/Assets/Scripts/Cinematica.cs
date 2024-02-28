using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cinematica : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject cocina;
    [SerializeField] GameObject sarten;
    [SerializeField] GameObject pan_infe;
    [SerializeField] GameObject pan_supe;
    [SerializeField] GameObject carne;
    [SerializeField] GameObject lechuga;
    [SerializeField] GameObject queso;
    [SerializeField] GameObject pepinillos;
    [SerializeField] GameObject cebolla;
    [SerializeField] GameObject tomate;
    [SerializeField] GameObject tocino;

    float delay = 3f;

    

    void Start()
    {
        StartCoroutine(Corrutina());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Corrutina()
    {
        yield return new WaitForSeconds(delay);
        Vector3 posicion = new Vector3(0, 5, 0);
        Quaternion rotacion1 = Quaternion.Euler(0, 0, 0);
        Quaternion rotacion2 = Quaternion.Euler(-90, 0, 0);

        GameObject spawnSarten = Instantiate(sarten, posicion, rotacion1);
        yield return new WaitForSeconds(delay);

        GameObject spawnPan_infe = Instantiate(pan_infe, posicion , rotacion2);
        yield return new WaitForSeconds(delay);

        GameObject spawnLechuga = Instantiate(lechuga, posicion, rotacion2);
        yield return new WaitForSeconds(delay);

        GameObject spawnCarne = Instantiate(carne, posicion, rotacion2);
        yield return new WaitForSeconds(delay);

        GameObject spawnQueso = Instantiate(queso, posicion, rotacion2);
        yield return new WaitForSeconds(delay);

        for (int i=0 ; i<2; i++) 
        {
            GameObject spawnPepinillos = Instantiate(pepinillos, posicion, rotacion1);
        }

        yield return new WaitForSeconds(delay);

        for (int i = 0; i < 2; i++)
        {
            GameObject spawnTomate = Instantiate(tomate, posicion, rotacion1);
        }

        yield return new WaitForSeconds(delay);

        for (int i = 0; i < 2; i++)
        {
            GameObject spawnCebolla = Instantiate(cebolla, posicion, rotacion1);
        }
        
        yield return new WaitForSeconds(delay);

        for (int i = 0; i < 2; i++)
        {
            GameObject spawnTocino = Instantiate(tocino, posicion, rotacion1);
        }
        
        yield return new WaitForSeconds(delay);

        GameObject spawnPan_supe = Instantiate(pan_supe, posicion, rotacion1);
        yield return new WaitForSeconds(delay);
    }
}
