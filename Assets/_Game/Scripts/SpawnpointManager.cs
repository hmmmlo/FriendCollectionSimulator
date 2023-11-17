using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{
    GameObject[] spawnPoints;
    private int _spawnIndex;
    private int[] _randomSpawnIndex;

    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        _spawnIndex = 0;

        GenerateRandomSpawnPoint();
    }

    void GenerateRandomSpawnPoint()
    {
        for(int i = 0; i<6; i++)
        {
            int r = Random.Range(1, 17);

            _randomSpawnIndex[i] = r;
        }
    }

    void SpawnFriends()
    {
        for (int i = 0; i < 6; i++)
        {

        }
    }
}
