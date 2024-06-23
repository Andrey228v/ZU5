using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    void Update()
    {
        if (_speedRotate != 0)
        {
            transform.Rotate(0, _speedRotate * Time.deltaTime, 0, Space.Self);
        }
    }
}
