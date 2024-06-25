using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    public int score;
    Animator animator;

    public static event Action<int> collectableEvent;
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
        collectableEvent?.Invoke(score);
        Destroy(gameObject);
    }
    public abstract void PowerUpAction();
}