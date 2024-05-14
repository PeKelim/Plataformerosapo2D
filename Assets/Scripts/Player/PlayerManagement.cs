using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagement : MonoBehaviour
{
    PlayerMovement movement;
    PlayerAnimations animations;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
        animations = GetComponent<PlayerAnimations>();
        movement.enabled = true;
    }
    public void TakeDamage()
    {
        animations.Damage();
        movement.enabled = false;
    }
}
