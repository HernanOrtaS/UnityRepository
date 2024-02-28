using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemigo : MonoBehaviour
{
    [SerializeField] private GameObject enemigo;
    [SerializeField] private List<Transform> posiciones = new List<Transform>();
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        int indice = Random.Range(0, posiciones.Count);
        Transform spawn = posiciones[indice];
        GameObject nuevoEnemigo = Instantiate(enemigo, spawn.position, Quaternion.identity);
    }
}
