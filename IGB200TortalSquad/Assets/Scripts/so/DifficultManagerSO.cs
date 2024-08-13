using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DataBank/New Difficulty Data")]
public class DifficultManagerSO : ScriptableObject
{
    [SerializeField] private float difficultyMeter;
    
    public float _difficultyMeter
    {
        get { return difficultyMeter; }
    }
}
