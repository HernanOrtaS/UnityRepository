using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigo : MonoBehaviour
{
    [SerializeField] List<GameObject> spawns;
    
    [SerializeField] GameObject enemigo_a_crear;

    [SerializeField] GameObject enemigo_actual;

    [SerializeField] int idx_spawn_selected;

    bool isCreated;

    // Start is called before the first frame update
    void Start()
    {
        isCreated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            if (!isCreated){    
                int position = Random.Range(0, spawns.Count);

                enemigo_actual = Instantiate (enemigo_a_crear,
                    spawns[position].transform.position,
                    spawns[position].transform.rotation);
                enemigo_actual.name = "Enemigo_Actual";
                isCreated = true;
            }
        }
    }
}
