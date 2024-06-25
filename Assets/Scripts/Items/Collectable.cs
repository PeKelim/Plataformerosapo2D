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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collect();
        }
    }
    protected void Collect()
    {
        animator.SetTrigger("Collected");
        PowerUpAction();
    }
    public void Dissapear()
    {
        Destroy(gameObject);
    }
    public abstract void PowerUpAction();
}