using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject prefabToInstantiate;

    public void SpawnNewPrefab()
    {
        GameObject gameObject = Instantiate(prefabToInstantiate, spawnPoint.position, Quaternion.identity);



    }

}
