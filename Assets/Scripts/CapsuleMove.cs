using UnityEngine;

public class CapsuleMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}
