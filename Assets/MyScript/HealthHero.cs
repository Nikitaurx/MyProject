using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHero : MonoBehaviour
{
    public Slider HealthBar;
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
        }
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        HealthBar.value = _currentHealth;
        Debug.Log(_currentHealth);
    }

    public void HpRegen(float hpUp)
    {
        _currentHealth += hpUp;
        HealthBar.value = _currentHealth;
        Debug.Log(_currentHealth);
    }
}
