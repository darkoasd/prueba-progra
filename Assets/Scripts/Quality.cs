using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quality : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            qualityLow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            qualityMedium();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            qualityHigh();
        }
    }
    public void qualityLow()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void qualityMedium()
    {
        QualitySettings.SetQualityLevel(2);
    }
    public void qualityHigh()
    {
        QualitySettings.SetQualityLevel(5);
    }
}
