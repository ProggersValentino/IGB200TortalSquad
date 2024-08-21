using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finishline : MonoBehaviour
{
    public TurtleRaceGameMan minigameMan; 
    
    public List<GameObject> FinishedRacers = new List<GameObject>();

    public UnityEvent processEnd;
    
    private void OnEnable()
    {
        processEnd.AddListener(minigameMan.ProcessEndOfMinigame);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //to determine the position the player achieved when finishing the race
    public void AddToFinishedRacers(GameObject finishedRacer)
    {
        FinishedRacers.Add(finishedRacer);
    }
}
