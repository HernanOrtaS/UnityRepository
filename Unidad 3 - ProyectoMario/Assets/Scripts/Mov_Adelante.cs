using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Adelante : MonoBehaviour
{
    [SerializeField] float velocidad = 10;
    [SerializeField] int delay;
    [SerializeField] bool destroy;

    private void Start()
    {
        if (destroy != false)
        {
            StartCoroutine(Corrutina());
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    private IEnumerator Corrutina()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
