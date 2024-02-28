using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DialogPersonaje_", menuName = "Conversacion/Crear Conversacion", order = 1)]
public class CrearConversacion : ScriptableObject
{
    [System.Serializable]
    public class Dialogo
    {
        public string nombre;
        public Sprite imagen;
        public string dialog;
        public float velTexto;
    }

    public List<Dialogo> dialogos = new List<Dialogo>();
}
