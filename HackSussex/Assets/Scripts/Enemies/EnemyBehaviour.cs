using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthController))]
public abstract class EnemyBehaviour : MonoBehaviour
{
    private HealthController _healthController;
    
    [SerializeField]
    private EnemyStatConfig _statsConfig;

    private void Awake()
    {
        _healthController = GetComponent<HealthController>();
        _healthController.OnTakeDamage += HealthController_OnOnTakeDamage;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //TODO: Tell the player controller to receive damage
            //TODO: Knockback the player
        }
    }
    
    private void HealthController_OnOnTakeDamage(object sender, HealthController.TakeDamageEventArgs e)
    {
        if (e.IsDead)
        {
            //TODO: Assign score to player
            Destroy(gameObject);
        }
    }
}
