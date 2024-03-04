
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyMover[] _prefab;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField][Range(1, 10)] private int _delay;
    [SerializeField] Target[] _target;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _delay)
        {
            int Index = Random.Range(0, _spawnPoint.Length);
            EnemyMover enemyTranslate = Instantiate(_prefab[Index], _spawnPoint[Index].position, Quaternion.identity);
            enemyTranslate.SetDirection(_target[Index]);
            _timer = 0;
        }
    }


 
}
