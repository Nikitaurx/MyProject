using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeleeEnemyMove : MonoBehaviour
{
    [SerializeField] GameObject _ghoulPrefab;
    [SerializeField] public Transform spawn_point;
    public List<GameObject> Ghoul; // список мобов

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        Spawn();
        //StartCoroutine(WaitAndSpawn());
        
    }
    IEnumerator WaitAndSpawn(){
        yield return new WaitForSeconds(5);
        Spawn();
    }
    void Spawn()
    {
        GameObject z = Instantiate(_ghoulPrefab, spawn_point);  // получаем точку спавна
        Ghoul.Add(z); // добавляем в список
    }

}
