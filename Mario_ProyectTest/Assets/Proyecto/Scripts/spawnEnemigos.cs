using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    [SerializeField]
    private GameObject objetoPrefabricado;

    [SerializeField]
    private List<Transform> posicionesDeSpawn = new List<Transform>();

    private void OnTriggerEnter(Collider other)
    {
        SpawnObjetoEnPosicionAleatoria();
    }

    private void SpawnObjetoEnPosicionAleatoria()
    {
        int indiceAleatorio = Random.Range(0, posicionesDeSpawn.Count);
        Transform posicionSeleccionada = posicionesDeSpawn[indiceAleatorio];

        GameObject nuevoObjeto = Instantiate(objetoPrefabricado, posicionSeleccionada.position, Quaternion.identity);
    }
}
