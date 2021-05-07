using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public float fireDelta = 0.5F;

    private float _nextFire = 0.5F;
    private GameObject _newProjectile;
    private float _myTime = 0.0F;

    void Update()
    {
        _myTime = _myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && _myTime > _nextFire)
        {
            _nextFire = _myTime + fireDelta;
            _newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;

            _nextFire = _nextFire - _myTime;
            _myTime = 0.0F;
        }
    }
}
