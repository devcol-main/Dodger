
using UnityEngine;
//using Random = UnityEngine.Random;

public class BulletSpawnTower : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float spawnRateMin = 0.5f, spawnRateMax = 3f;
    //[SerializeField] private float bulletSpeed;

    private Player _player;
    private Transform _targetTransform;
    private float _spawnRate;
    private float _lastSpawnTime;

    private void Start()
    {
        _player = FindAnyObjectByType<Player>();
        _targetTransform = _player.transform;
        
        _lastSpawnTime = 0f;
        _spawnRate = UnityEngine.Random.Range(spawnRateMin, spawnRateMax);
    }
}
