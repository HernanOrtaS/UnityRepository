using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Personaje_", menuName = "Conversacion/Crear Personaje", order = 1)]
public class Personaje : ScriptableObject
{
    public string nombre;
    public Sprite imagen;
}
