using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy/Enemy Stat Config")]
public class EnemyStatConfig : ScriptableObject
{
    [Header("Base")]
    
    [SerializeField]
    private float _health;
    [SerializeField]
    private float _physicalDamage;
    [SerializeField]
    private float _movementSpeed;

    public float Health => _health;
    public float PhysicalDamage => _physicalDamage;
    public float MovementSpeed => _movementSpeed;

    [Header("Weapons - LVL 2")]
    
    [SerializeField]
    private float _fireRate;
    [SerializeField]
    private float _weaponDamage;
    
    public float FireRate => _fireRate;
    public float WeaponDamage => _weaponDamage;
}
