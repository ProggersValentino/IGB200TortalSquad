using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyBar : MonoBehaviour
{
    
    public DifficultManagerSO difficultyData;

    public Image barImage;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI(barImage);
    }
    
    public void UpdateUI(Image image)
    {
        image.fillAmount = difficultyData._difficultyMeter / 100;
    }
}
