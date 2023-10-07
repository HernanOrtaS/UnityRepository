using UnityEngine;

public class IniciaAudioLoop : MonoBehaviour
{
    [SerializeField] AudioSource audioInicial;  // El audio que se reproduce primero
    [SerializeField] AudioSource audioLoop;  // El audio que se reproduce indefinidamente

    private void Start()
    {
        // Configurar el audio inicial y reproducirlo
        audioInicial.Play();
    }

    private void Update()
    {
        // Verificar si el audio inicial ha terminado de reproducirse
        if (!audioInicial.isPlaying && !audioLoop.loop)
        {
            // Configurar el audio indefinido y reproducirlo en bucle
            audioLoop.loop = true;
            audioLoop.Play();
        }
    }
}
