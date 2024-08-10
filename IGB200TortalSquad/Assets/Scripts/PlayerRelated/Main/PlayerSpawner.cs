using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public SpawnObjectSO player;
    public PlayerSO playerData;

    // Start is called before the first frame update
    void Start()
    {
        player.SpawnObject(playerData._lastPlayerLocoBeforeSceneChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
