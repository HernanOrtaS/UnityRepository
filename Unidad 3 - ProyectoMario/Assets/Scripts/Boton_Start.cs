using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Start : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string SiguienteEscena;
    public void CambiarEscena()
    {
        SceneManager.LoadScene(SiguienteEscena);
    }
}
