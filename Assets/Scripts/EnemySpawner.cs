
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _cubePrefab;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] [Range(1,10)] private int _delay;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _delay)
        {
            int Index = Random.Range(0, _spawnPoint.Length);
            EnemyMover enemyTranslate = Instantiate(_cubePrefab, _spawnPoint[Index].position, Quaternion.identity);
            Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
            enemyTranslate.SetDirection(direction);
            _timer = 0;
        }
    }


 
}
