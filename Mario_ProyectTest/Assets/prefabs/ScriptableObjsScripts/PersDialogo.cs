using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DialogPersonaje_", menuName = "Conversacion/Crear Personaje Con Dialogo", order = 1)]
public class PersDialogo : ScriptableObject
{
    public string nombre;
    public Sprite imagen;
    public string dialog;
    public float velTexto;
}

