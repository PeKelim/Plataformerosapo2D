using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    protected void Collect()
    {
        animator.SetTrigger("Collected");
    }
    public void Dissapear()
    {
        Destroy(gameObject);
    }
}