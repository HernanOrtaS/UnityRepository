using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float Caminar = 5.0f; // Velocidad de caminar.
    public float Correr = 10.0f; // Velocidad de correr.
    public float fSalto = 10.0f; // Fuerza del salto.

    private bool boolSaltar = true;
    float vHorizontal = 0f;
    float movHorizontal = 0f;
    float movVertical = 0f;

    float baileNum = 0f;
    int bailesTotales = 6;

    Rigidbody rBody;
    Animator animator;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        movHorizontal = 0;
        movVertical = 0;

        // Comprueba si el movimiento será caminar o correr
        if (Input.GetKey(KeyCode.LeftShift))
        {
            vHorizontal = Correr;
        }
        else
        {
            vHorizontal = Caminar;
        }

        // Movimiento con teclas WASD

        if (Input.GetKey(KeyCode.W))
        {
            movVertical = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movVertical = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movHorizontal = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movHorizontal = -1;
        }

        // Controla las animaciones, dependiendo de si se está quieto o se mueve
        if (movHorizontal == 0 && movVertical == 0)
        {
            animator.SetFloat("Movs", 0);
        }
        else
        {
            animator.SetFloat("Movs", vHorizontal/10);
        }

        if (Input.GetKey(KeyCode.B))
        {
            animator.SetFloat("Movs", -(baileNum+1));
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            baileNum++;
            if (baileNum == bailesTotales) { baileNum = 0; }
            
        }
        /*
        // Control de animaciones
        if (movHorizontal == 0 && movVertical == 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                animator.SetFloat("Movs", -1);
            }
            else
            {
                animator.SetFloat("Movs", 0);
            }
        }
        else
        {
            animator.SetFloat("Movs", vHorizontal / 5);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Agacharse();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            dePie();
        }
        */

        // Aplica el movimiento al personaje en la dirección global
        Vector3 movimiento = new Vector3(movHorizontal, 0, movVertical) * vHorizontal * Time.deltaTime;
        transform.position += movimiento;

        if (movimiento != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movimiento);
            transform.rotation = newRotation;
        }

        // Salto con la tecla R
        if (Input.GetKeyDown(KeyCode.R) && boolSaltar)
        {
            // Realiza un Raycast hacia abajo para verificar si el personaje está en el suelo
            RaycastHit hit;
            float distanciaRaycast = 1.1f; // Ajusta esta distancia según la altura de tu personaje
            Debug.DrawRay(transform.position, Vector3.down, Color.red);
            if (Physics.Raycast(transform.position, Vector3.down, out hit, distanciaRaycast))
            {
                rBody.AddForce(Vector3.up * fSalto, ForceMode.Impulse);
                boolSaltar = false;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Cuando el personaje toca el suelo, le permite saltar nuevamente
        if (collision.gameObject.CompareTag("Suelo"))
        {
            boolSaltar = true;
        }
    }

    /*
    void dePie()
    {
        CapsuleCollider collider = GetComponent<CapsuleCollider>();
        // Activa la animación "MiAnimacion".
        //animaciones.SetTrigger("MiAnimacionTrigger");

        // Cambia el centro y la altura del Collider.
        collider.center = new Vector3(0, -0.15f, 0);
        collider.height = 1.7f;
        animator.SetFloat("Agacharse", 0);
    }

    void Agacharse()
    {
        CapsuleCollider collider = GetComponent<CapsuleCollider>();
        // Activa la animación "MiAnimacion".
        //animaciones.SetTrigger("MiAnimacionTrigger");

        // Cambia el centro y la altura del Collider.
        collider.center = new Vector3(0, -0.5f, 0);
        collider.height = 1.0f;
        animator.SetFloat("Agacharse", 1);
    }*/
}
