using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _speedScale;

    private void Update()
    {

        if(_speedMove != 0)
        {
            transform.position += transform.forward * _speedMove * Time.deltaTime;
        }

        if(_speedRotate != 0)
        {
            transform.Rotate(0, _speedRotate * Time.deltaTime, 0, Space.Self);
        }

        if(_speedScale != 0)
        {
            transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale) * Time.deltaTime;
        }
    }
}
