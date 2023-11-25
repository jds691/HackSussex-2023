using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemyBehaviour : EnemyBehaviour
{
    protected int p_movementDirectionX = -1;

    private void Update()
    {
        var position = transform.position;
        
        position = Vector3.MoveTowards(position, new Vector3(position.x + p_movementDirectionX, position.y, position.z),
            p_StatsConfig.MovementSpeed * Time.deltaTime);
        transform.position = position;
    }
}
