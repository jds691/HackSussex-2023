using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private float _health;

    public float Health
    {
        get => _health;
        set => _health = value;
    }

    public event EventHandler<TakeDamageEventArgs> OnTakeDamage;

    public void TakeDamage(float damage)
    {
        _health -= damage;
        
        OnTakeDamage?.Invoke(this, new TakeDamageEventArgs(_health, _health <= 0));
    }

    public class TakeDamageEventArgs : EventArgs
    {
        private float _currentHealth;
        private bool _isDead;

        public float CurrentHealth => _currentHealth;
        public bool IsDead => _isDead;

        public TakeDamageEventArgs(float currentHealth, bool isDead)
        {
            _currentHealth = currentHealth;
            _isDead = isDead;
        }
    }
}
