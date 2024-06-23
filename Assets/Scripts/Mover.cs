using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    
    private void Update()
    {
        if(_speedMove != 0)
        {
            transform.position += transform.forward * _speedMove * Time.deltaTime;
        }
    }
}
