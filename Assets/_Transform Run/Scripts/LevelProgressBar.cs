using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressBar : MonoBehaviour
{
    private GameObject finishLineObj;
    private Slider levelProgressSlider;
    private float finishLineZValue;
    private float playerZValue;


    private void Awake()
    {
        levelProgressSlider = GameObject.Find("Slider_LevelProgress").GetComponent<Slider>();
        finishLineObj = GameObject.FindWithTag("Finish Line");
    }

    private void Start()
    {
        finishLineZValue = finishLineObj.transform.position.z;
        levelProgressSlider.minValue = 0;
        levelProgressSlider.maxValue = finishLineZValue;
    }
    
    private void Update()
    {
        CalculateSliderValue();
    }

    private void CalculateSliderValue()
    {
        playerZValue = transform.position.z;
        levelProgressSlider.value = playerZValue;
    }

  
}
