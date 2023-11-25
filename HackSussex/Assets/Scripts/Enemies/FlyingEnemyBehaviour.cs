using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyBehaviour : EnemyBehaviour
{
    [SerializeField]
    private Vector3[] _flightPath;
    [SerializeField]
    private bool _loopPath;

    private int _direction = 1;
    private int _currentPathNode = 0;

    private Vector3 _lastPosition;

    private void Awake()
    {
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
            _currentPathNode += _direction;
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
                    _direction = -1;
                }

                _currentPathNode = _flightPath.Length - 1;
            }
            else if (_currentPathNode <= 0)
            {
                if (!_loopPath)
                {
                    Destroy(gameObject);
                }
                else
                {
                    _direction = 1;
                }

                _currentPathNode = 0;
            }
        }
    }
}