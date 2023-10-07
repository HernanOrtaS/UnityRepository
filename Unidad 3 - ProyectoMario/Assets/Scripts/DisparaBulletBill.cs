using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparaBulletBill : MonoBehaviour
{
    [SerializeField] int delay;
    [SerializeField] bool disparar;
    [SerializeField] GameObject PlantillaEnemigo;
    [SerializeField] GameObject slot;

    private void Start()
    {
        StartCoroutine(Corrutina());
    }

    private IEnumerator Corrutina()
    {
        while (disparar)
        {
            yield return new WaitForSeconds(delay);
            Vector3 posicion = slot.transform.position;
            Quaternion rotacion = slot.transform.rotation;

            GameObject objNuevo = Instantiate(PlantillaEnemigo, posicion, rotacion);
        }
        
    }
}
