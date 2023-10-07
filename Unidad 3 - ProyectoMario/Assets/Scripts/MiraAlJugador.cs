using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraAlJugador : MonoBehaviour
{
    [SerializeField]
    GameObject enemigo;
    LookAt look;

    // Start is called before the first frame update
    void Start()
    {
        look = enemigo.GetComponent<LookAt>(); 
    }

    // Update is called once per frame
    void Update()
    {
        look.JugadorEnLaMira = true;
    }
}
