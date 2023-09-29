using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(transform.up*speed*Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(transform.up*(-1)*speed*Time.deltaTime);
        }
    }
}
