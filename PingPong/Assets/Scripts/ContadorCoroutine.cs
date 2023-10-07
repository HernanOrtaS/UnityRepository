using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorCoroutine : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI txt_contador;
    int contador = 0;
    float tiempoActual;

    string tiempoFormato = "0";

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        StopAllCoroutines();
        StartCoroutine("counter_routine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator counter_routine(){
        while (true)
        {
            tiempoFormato = convertirFormato(contador);
            contador++;
            txt_contador.text = tiempoFormato;
            yield return new WaitForSeconds(1f);
            
        }
    }

    private string convertirFormato (int noProcesado) {
        int minutos = noProcesado/60;
        int segundos = noProcesado%60;
        tiempoFormato = $"{minutos:D2} : {segundos:D2}"; 
        return tiempoFormato;
    }
}
