using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTurret : MonoBehaviour
{
    [SerializeField] GameObject m_target;   
    private GameObject _player;   
    Vector3 m_lastKnownPosition = Vector3.zero;
    Quaternion m_lookAtRotation;
    public float speed = 3.0f; 
    [SerializeField] int _damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () 
    {
        if(m_target)
        {
            if (m_lastKnownPosition != m_target.transform.position)
            {
                m_lastKnownPosition = m_target.transform.position;
                m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
            }
    
            if(transform.rotation != m_lookAtRotation)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);
            }
        }
        
    }
    // comment new
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            //_player.GetComponent<HealthHero>().TakeDamage(_damage);            
        }
    }

    public void SetTarget(GameObject target)
    {
        m_target = target;
    }

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    } 
}
