using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTurret : MonoBehaviour
{
    private GameObject _player; 
    [SerializeField] private Transform _target1;
    Vector3 _direction;
    [SerializeField] GameObject m_target;
    [SerializeField] int _damage;
    int _attackSpeed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // частично
    // мобилизацион
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target1.position, speed * Time.deltaTime);
    }

    public void FireProjectile() 
    {
        
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

}
