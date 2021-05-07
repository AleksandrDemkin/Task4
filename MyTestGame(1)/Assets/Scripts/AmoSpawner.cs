using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _amo;
    [SerializeField] private Transform _amoSpawnPoint;
    private void Start()
    {
        Instantiate(_amo, _amoSpawnPoint.position, _amoSpawnPoint.rotation);
    }
}
