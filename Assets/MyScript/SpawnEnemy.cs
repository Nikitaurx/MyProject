using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject _ghoulPrefab;
    [SerializeField] public Transform spawn_point;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        Spawn();
        //StartCoroutine(WaitAndSpawn());

    }
    IEnumerator WaitAndSpawn()
    {
        yield return new WaitForSeconds(5);
        Spawn();
    }
    void Spawn()
    {
        GameObject z = Instantiate(_ghoulPrefab, spawn_point);  // получаем точку спавна
    }
}
