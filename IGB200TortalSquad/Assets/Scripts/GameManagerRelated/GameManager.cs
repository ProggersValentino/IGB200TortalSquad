using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image difficultyBarUI;
    
    public GameObject microTaskPref;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SummonMicroTasks(microTaskPref);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    /// <summary>
    /// 
    /// </summary>
    public void SummonMicroTasks(GameObject pref)
    {
        GameObject newMicroTask = Instantiate(pref, new Vector3(19.5f, 0.74000001f, 1.92999995f), pref.transform.rotation);

        MicroTask summonedMTask = newMicroTask.GetComponent<MicroTask>();
        //summonedMTask.ShiftDifficultyLevel += difficultyLevel.CalculateDifference;
    }
    
}
