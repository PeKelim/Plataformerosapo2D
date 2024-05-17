using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneEnemy : Enemy
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoseLife(1f);
    }
    void Stomp()
    {
        // El enemigo golpeará el suelo cuando el jugador pase por debajo
    }
}
