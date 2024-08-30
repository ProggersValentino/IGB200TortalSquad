using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image difficultyBarUI;
    
    public GameObject microTaskPref;

    private void OnEnable()
    {
        
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        // MultipleSceneManager.SetActiveScene("RangerPerspective");   
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

        //Undo.MoveGameObjectToScene(newMicroTask, SceneManager.GetSceneByName("RangerPerspective"), "yes");
        newMicroTask.transform.SetParent(transform, true); //to prevent it from running away to the other active scenes (pain)
        
        MicroTask summonedMTask = newMicroTask.GetComponent<MicroTask>();
        //summonedMTask.ShiftDifficultyLevel += difficultyLevel.CalculateDifference;
    }
    
}
