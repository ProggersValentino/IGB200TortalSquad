using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class TurtleRaceGameMan : MonoBehaviour
{
    public DifficultManagerSO difficultyLevel;

    public GameObject obstaclePref;
    public int obstacleCount;

    [Range(0, 3)] public float multiplierEnhancer = 1;

    public Transform startSpawnPoint;
    public Transform endSpawmPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        // mapVertices = raceMap.GetComponent<MeshFilter>().mesh.vertices.Distinct().ToList();
        //
        // Debug.LogWarning(FindMinMaxSpawnPoint(false, mapVertices));
        // Debug.LogWarning(FindMinMaxSpawnPoint(true, mapVertices));
        
        SummonObstacles(obstaclePref);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// determines how tricky the area will be to navigate
    /// </summary>
    /// <returns></returns>
    public int DetermineObstacleCount()
    {
        return (int)((obstacleCount * difficultyLevel._difficultyMeter) * multiplierEnhancer) / 10; //divide by 10 to make it not so crazy
    }
    
    /// <summary>
    /// spawn the obstacles
    /// </summary>
    /// <param name="obstaclePref"></param>
    public void SummonObstacles(GameObject obstaclePref)
    {
        int amountToSummon = DetermineObstacleCount();
        
        for (int i = 0; i < amountToSummon; i++)
        {
            Vector3 randomPoint = new Vector3(Random.Range(startSpawnPoint.position.x, endSpawmPoint.position.x),
                0.2f,
                Random.Range(startSpawnPoint.position.z, endSpawmPoint.position.z));

            Instantiate(obstaclePref, randomPoint, obstaclePref.transform.rotation);
        }
    }

    /// <summary>
    /// when the player crosses the finishline we want to process the end of the game
    /// like score and rewards etc
    /// </summary>
    public void ProcessEndOfMinigame()
    {
        
    }
}
