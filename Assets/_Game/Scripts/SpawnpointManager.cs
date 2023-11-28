using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnPointManager : MonoBehaviour
{
    GameObject[] spawnPoints;
    private int[] _randomSpawnIndex = new int[6];

    [SerializeField] GameObject[] _friendPrefab = new GameObject[6];

    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        //print(spawnPoints.Length);

        GenerateRandomSpawnPoint();

        SpawnFriends();
    }

    void GenerateRandomSpawnPoint()
    {
        for(int i = 0; i<6; i++)
        {
            int r = Random.Range(0, 16);

            if(!_randomSpawnIndex.Contains(r))
            {
                _randomSpawnIndex[i] = r;
            }
            else
            {
                r = Random.Range(0, 16);
                _randomSpawnIndex[i] = r;
            }

            print(_randomSpawnIndex[i]);
        }
    }

    void SpawnFriends()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(_friendPrefab[i], spawnPoints[_randomSpawnIndex[i]].transform.position, spawnPoints[_randomSpawnIndex[i]].transform.rotation);

            //print("friend spawned");
        }
    }
}
