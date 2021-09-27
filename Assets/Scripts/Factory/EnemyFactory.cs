using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    public GameObject[] enemyPrefabs;
    
    // TODO: implement random spawn point
    public GameObject FactoryMethod(int tag)
    {
        GameObject enemy = Instantiate(enemyPrefabs[tag]);
        return enemy;
    }
}
