using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagement : MonoBehaviour
{
    PlayerMovement movement;
    PlayerAnimations animations;

    public bool isDamaged;
    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
        animations = GetComponent<PlayerAnimations>();
    }
    public void TakeDamage()
    {
        animations.Damage();
        isDamaged = true;
        movement.enabled = false;
    }
}
