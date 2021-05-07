using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }

    }
}
