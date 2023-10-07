using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBala : MonoBehaviour
{
    [SerializeField]
    GameObject arma; //se vinculara desde inpesctor

    [SerializeField]
    GameObject Bala_a_Instanciar; //se vinculara desde inpesctor

    [SerializeField]
    GameObject Lugar_a_Spawnear; //se vinculara desde inpesctor

    int cont_bala;

    private void Awake()
    {             
    }

    // Start is called before the first frame update
    void Start()
    {
        cont_bala = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            //if (arma.name == "arma1") {
            GameObject bala_clonada = Instantiate(Bala_a_Instanciar,
                Lugar_a_Spawnear.transform.position,
                Lugar_a_Spawnear.transform.rotation
                );
            bala_clonada.name = "bala_" + cont_bala++;
            Destroy(bala_clonada, 5);
            //}
        }
    }
}
