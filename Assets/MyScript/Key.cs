using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private GameObject _player;
    private GameObject _key;
    private GameObject _door;
    private bool _pickUpKey;

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
            _pickUpKey = true;
            Destroy(_key);
        }
        print("Key has been picked");

        if (other.gameObject == _player && _pickUpKey == true)
        {
            Destroy(_door);
            _pickUpKey = false;
        }
        
    }


    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _key = GameObject.FindGameObjectWithTag("Key");
        _door = GameObject.FindGameObjectWithTag("Door");
    }

}
