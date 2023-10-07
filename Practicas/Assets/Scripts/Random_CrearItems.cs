using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_CrearItems : MonoBehaviour
{
    [SerializeField] GameObject PlantillaEnemigo;

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
            float randomX = Random.Range(-7f, 7f);
            float randomZ = Random.Range(-7f, 7f);

            // Crear una nueva posición aleatoria dentro del área de generación
            Vector3 randomPosition = new Vector3(randomX, 1f, randomZ);

            // Instanciar un nuevo enemigo en la posición aleatoria
            GameObject objNuevo = Instantiate(PlantillaEnemigo,
                randomPosition,
                Quaternion.identity // No aplicar rotación especial
            );
        }
    }
}
