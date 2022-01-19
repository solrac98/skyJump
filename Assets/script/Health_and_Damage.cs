using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_Damage : MonoBehaviour
{
    public int vida = 100;

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }
}