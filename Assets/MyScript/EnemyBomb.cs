using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomb : MonoBehaviour
{
    private GameObject _player;
    private bool _collidedWithPlayer;
    [SerializeField] private float _damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_collidedWithPlayer)
        {
            _player.GetComponent<HealthHero>().TakeDamage(_damage);
        }
    }

    private void OnTriggerEnter(Collider other)
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