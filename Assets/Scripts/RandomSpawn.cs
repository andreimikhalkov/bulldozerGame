using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _trashPrefabs;
    [SerializeField]
    private Vector3[] _spawnPoints;
    [SerializeField]
    private int prefabCount;
    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomObjects()
    {
        for(int i =0; i > prefabCount; i++)
        {
            int randomIndex = Random.Range(0, _spawnPoints.Length);
            Instantiate(_trashPrefabs[randomIndex]);

        }
    }
}
