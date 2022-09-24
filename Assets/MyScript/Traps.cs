using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    private GameObject _player;
    private bool _collidedWithPlayer;
    [SerializeField] private float _damage;

    void Update()
    {
        if (_collidedWithPlayer)
        {
            _player.GetComponent<HealthHero>().TakeDamage(_damage);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == _player)
        {
            _player.GetComponent<HealthHero>().TakeDamage(_damage);
        }

        print("enter collided with _player");
    }

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
}
