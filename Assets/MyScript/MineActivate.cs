using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineActivate : MonoBehaviour
{
    [SerializeField] float _damage;
    private GameObject _enemy;
    private GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 impulse = new Vector3(-7, 2);
        if (other.gameObject.CompareTag("Enemy"))
        {
            _enemy.GetComponent<HealthEnemy>().TakeDamage(_damage);
            _enemy.GetComponent<Rigidbody>().AddForce(Vector3.back, ForceMode.Force);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<HealthHero>().TakeDamage(_damage - 20);
            _player.GetComponent<Rigidbody>().AddForce(0, 0, 50, ForceMode.Force);
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");
        _player = GameObject.FindGameObjectWithTag("Player");
    }

}
