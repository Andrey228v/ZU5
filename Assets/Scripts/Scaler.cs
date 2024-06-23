using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    void Update()
    {
        if (_speedScale != 0)
        {
            transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale) * Time.deltaTime;
        }
    }
}
