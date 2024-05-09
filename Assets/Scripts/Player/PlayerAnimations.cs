using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    PlayerMovement movement;
    Rigidbody2D rb;
    Animator animator;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }
    void Running()
    {
    }
}
