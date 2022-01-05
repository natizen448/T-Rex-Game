using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMob : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Mob"))
        {
            GameManager.isGameEnd = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Mob"))
        {
            GameManager.isGameEnd = true;
        }
    }
}
