using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public float Health = 100;

    private float _currentHealth;

    void Start()
    {
        _currentHealth = Health;
    }

    void Update()
    {
        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Враг убит");
        }
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        Debug.Log(_currentHealth);
    }
}
