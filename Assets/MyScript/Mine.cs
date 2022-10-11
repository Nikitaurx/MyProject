using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] GameObject _mine;
    [SerializeField] Transform _mineSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            Instantiate(_mine, _mineSpawnPoint.position, _mineSpawnPoint.rotation);
        }
    }
}
