
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    private void Update()
    {
        transform.position= Vector3.MoveTowards (transform.position, _target.transform.position,_speed * Time.deltaTime);
    }

    public void SetDirection(Target target)
    {
        _target = target;
    }
}
