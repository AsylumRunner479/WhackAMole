using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float SpawnTime;
    public GameObject Enemy;
    private Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTime += Time.deltaTime;
        if (SpawnTime >= 0)
        {
            spawnPoint.x = Random.Range(-5, 15);
            spawnPoint.y = Random.Range(-5, 15);
            Instantiate(Enemy, spawnPoint, Quaternion.identity);
            SpawnTime -= Time.timeScale;
        }
    }
}
