using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Collectable
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collect();
        AddJump();
    }
    void AddJump()
    {
        // Esta funci�n a�adir� fuerza de salto
    }
}
