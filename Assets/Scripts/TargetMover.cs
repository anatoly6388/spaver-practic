using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _speed;

    private int _currentWayPoint = 0;

    private void Update()
    {
        if(transform.position == _wayPoints[_currentWayPoint].position)
        {
            _currentWayPoint = Random.Range (0, _wayPoints.Length);
        }

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPoint].position, _speed*Time.deltaTime);
    }
}
