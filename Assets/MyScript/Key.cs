using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private GameObject _player;
    private GameObject _key;
    private GameObject _door;
    private bool leverActive;
    public Animator animVorota;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            leverActive = true;
            animVorota.SetBool("OnLever", leverActive);
        }

    }


    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _door = GameObject.FindGameObjectWithTag("Door");
    }

}
