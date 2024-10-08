using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyManager : Observer
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int enemyCount = 20;
    [SerializeField] private GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, new Vector3(Random.Range(-8, 8), 4, 0), Quaternion.identity);
    }

    public override void Notify()
    {
        enemyCount--;
        if (enemyCount == 0)
        {
            win.SetActive(true);
        }
    }
}
