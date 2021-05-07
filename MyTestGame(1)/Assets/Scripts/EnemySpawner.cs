using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _enemySpawnPlace;
    private void Start()
    {
        Instantiate(_enemy, _enemySpawnPlace.position, _enemySpawnPlace.rotation);
    }
}
