using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    
    void LateUpdate()
    {
        var position = transform.position;
        transform.position = new Vector3(_target.position.x, position.y, position.z);
    }
}
