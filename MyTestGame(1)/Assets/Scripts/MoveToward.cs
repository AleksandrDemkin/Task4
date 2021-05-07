using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 1;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
