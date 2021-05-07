using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUp : MonoBehaviour
{
    
    [SerializeField]
    private float _speed = 1;

    
    void Update()
    {

        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}
