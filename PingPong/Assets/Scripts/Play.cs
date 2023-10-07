using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] string SiguienteEscena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Al ejecutar este script, hará el cambio hacia la escena 2
    public void CambiarEscena()
    {
        SceneManager.LoadScene(SiguienteEscena);
    }
}
