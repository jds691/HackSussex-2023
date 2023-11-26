using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FlyingEnemyBehaviour : EnemyBehaviour
{
    [SerializeField]
    private Vector3[] _flightPath;
    [SerializeField]
    private bool _loopPath;

    private int _currentPathNode = 0;

    private Vector3 _lastPosition;

    protected override void Awake()
    { 
        base.Awake();
        
        _lastPosition = transform.position;
    }

    private void Update()
    {
        Vector3 target = _lastPosition + _flightPath[_currentPathNode];
        var position = transform.position;
        
        position = Vector3.MoveTowards(position, target,
            p_StatsConfig.MovementSpeed * Time.deltaTime);
        
        transform.position = position;

        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            _currentPathNode++;
            _lastPosition = target;
            transform.position = position;
            
            if (_currentPathNode >= _flightPath.Length)
            {
                if (!_loopPath)
                {
                    Destroy(gameObject);
                }
                else
                {
                    ReverseFlightPath();
                    _currentPathNode = 0;
                }
            }
        }
    }

    private void ReverseFlightPath()
    {
        Array.Reverse(_flightPath);

        for (int i = 0; i < _flightPath.Length; i++)
        {
            _flightPath[i] *= -1;
        }
    }
}
