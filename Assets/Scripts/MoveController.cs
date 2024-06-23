using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        transform.position += transform.forward * _speedMove * Time.deltaTime;
        transform.Rotate(0, _speedRotate * Time.deltaTime, 0, Space.Self);
        transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale) * Time.deltaTime;
    }
}
