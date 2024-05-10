using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerManagement management;
    private void Start()
    {
        management = GetComponent<PlayerManagement>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            management.TakeDamage();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         
    }
}
