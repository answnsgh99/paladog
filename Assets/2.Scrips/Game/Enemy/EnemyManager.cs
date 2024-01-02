using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private PlayerChar pc;
    [SerializeField] private Enemy[] enemies;
    [SerializeField] private GameObject parent;
    [SerializeField] private float spawnDelay;

    private float spawnTimer = float.MaxValue;


    void Update()
    {
        
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnDelay)
        {
            spawnTimer = 0;
            int sprand = Random.Range(3, 7);
            spawnDelay = sprand;

            int rand = Random.Range(0, 100);
            int index = (rand < 80) ? 0 : (rand < 95) ? 1 : 2; 
            Instantiate(enemies[index], parent.transform.position, Quaternion.identity);

        }   
    }

    
    
}
