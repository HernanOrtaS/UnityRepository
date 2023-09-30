using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //[SerializeField]
    private string Escena_Nueva = "Principal";

    public void CambiarEscena(){
        SceneManager.LoadScene(Escena_Nueva, LoadSceneMode.Single);
    }
}
