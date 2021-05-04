using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleFlash : MonoBehaviour
{
    [SerializeField] private GameObject flash;
    [SerializeField] private float timeFromLastFlash;
    [SerializeField] private float minTimeToFlash = 0.5f;
    [SerializeField] private float maxTimeToFlash = 1f;
    private void Update()
    {
        timeFromLastFlash = timeFromLastFlash + Time.deltaTime;

        if(timeFromLastFlash >= 0.2f)
        {
            timeFromLastFlash = 0;
            flash.SetActive(true);
            Invoke("SetFlashToFalse", 0.1f);
        }
    }
    private void SetFlashToFalse()
    {
        flash.SetActive(false);
    }
}
