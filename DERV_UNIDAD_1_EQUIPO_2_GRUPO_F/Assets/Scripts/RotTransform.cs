using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotTransform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int speed = 200;
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] int z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //transform.Rotate(transform.right);
      //transform.Rotate(new Vector3(x, y, z), speed*Time.deltaTime);

        if (Input.GetKey(KeyCode.W)){
            transform.Rotate(transform.forward*speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)){
            transform.Rotate(transform.forward*(-1)*speed*Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(transform.right*speed*Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(transform.right*(-1)*speed*Time.deltaTime);
        }
    }
}
