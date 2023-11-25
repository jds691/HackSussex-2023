using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyStatConfig _statsConfig;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //TODO: Tell the player controller to receive damage
            //TODO: Knockback the player
        }
    }
}
