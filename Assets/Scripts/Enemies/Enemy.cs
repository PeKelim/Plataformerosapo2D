using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float life;

    protected void LoseLife(float damage)
    {
        life -= damage;

    } // Función para que el enemigo reciba daño
}
