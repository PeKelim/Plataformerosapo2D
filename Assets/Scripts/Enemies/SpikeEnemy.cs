using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnemy : Enemy
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoseLife(1f);
    }
    void RandomMovement()
    {
        // El enemigo se mover� de forma vertical u horizontal de forma aleatoria
    }
}
