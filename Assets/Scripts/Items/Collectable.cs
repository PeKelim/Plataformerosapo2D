using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Collect()
    {
        animator.SetTrigger("Collected");
    }
    public void Dissapear()
    {
        Destroy(gameObject);
    }
}