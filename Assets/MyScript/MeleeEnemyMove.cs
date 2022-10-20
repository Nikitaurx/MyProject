using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MeleeEnemyMove : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] Transform _pointToSecure1;
    [SerializeField] Transform _pointToSecure2;
    public List<Transform> targets;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // void Update()
    // {
    //     if (agent.transform.position == agent.pathEndPosition)
    //     {

    //     }
    //     agent.SetDestination(_pointToSecure1);
    // }
}
