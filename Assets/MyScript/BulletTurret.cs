using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTurret : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private Transform _target;
    Vector3 _direction;
    [SerializeField] int _damage;
    [SerializeField] int _attackSpeed;
    public float speed;
    public List<GameObject> Bullet;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform spawn_point_bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        WaitAndSpawn();
    }

    public void Fire()
    {

    }
    public void Spawn()
    {
        //GameObject bul = new GameObject();
        GameObject bul = Instantiate(_bulletPrefab, spawn_point_bullet);  // получаем точку спавна
        //Bullet.Add(bul); // добавляем в список

    }
    public IEnumerator WaitAndSpawn()
    {
        yield return new WaitForSeconds(_attackSpeed);
        Spawn();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            _player.GetComponent<HealthHero>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    //старая версия

}
