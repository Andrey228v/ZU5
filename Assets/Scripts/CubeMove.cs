using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0, Space.Self);
    }
}
