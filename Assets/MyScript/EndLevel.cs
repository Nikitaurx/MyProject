using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject _player;

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            Debug.Log("Level complete!");
            Destroy(other);
        }
    }

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
}
