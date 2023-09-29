using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objetoRespawn;
    [SerializeField] private AudioSource gol;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        string name = obj.name;
        Debug.Log("Entra en Trigger con: " + name);
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        gol.Play();
        yield return new WaitForSeconds(3f);
        objetoRespawn.position = new Vector3(0, 5, 0);
        yield return new WaitForSeconds(.1f);
        objetoRespawn.position = new Vector3(0, 5, 0);
        yield return new WaitForSeconds(.1f);
        objetoRespawn.position = new Vector3(0, 5, 0);
        yield return new WaitForSeconds(.1f);
        objetoRespawn.position = new Vector3(0, 5, 0);
        yield return new WaitForSeconds(.1f);
        objetoRespawn.position = new Vector3(0, 5, 0);
    }
}
