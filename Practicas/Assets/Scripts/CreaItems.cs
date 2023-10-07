using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaItems : MonoBehaviour
{
    [SerializeField] GameObject PlantillaEnemigo;
    [SerializeField] List<GameObject> Spawns;
    public int index_new_enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Generar posiciones aleatorias en el rango (-5, 5) en los ejes X y Z
            index_new_enemy = Random.Range(0, 9);

            GameObject nlocation = Spawns[index_new_enemy];

            GameObject objNuevo = Instantiate(PlantillaEnemigo,
                nlocation.transform.position,
                nlocation.transform.rotation
                );
        }
    }
}
