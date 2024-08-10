using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DataBank/Spawn Object Data")]
public class SpawnObjectSO : ScriptableObject
{
    public GameObject objectToSpawn;

    public void SpawnObject(Vector3 spawnPosition)
    {
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
