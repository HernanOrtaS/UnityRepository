using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    [SerializeField] float velocidad = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * velocidad * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * velocidad * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * -1 * velocidad * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(transform.up * 10 * Time.deltaTime);
        }
    }
}
