using UnityEngine;
using UnityEngine.UI;
using System;

public class UIProgressBar : MonoBehaviour
{
    [SerializeField] private float fillSpeed =1f;
    [SerializeField] private Image fillBar; 
    private float currentFill = 0f; 

    public void FillOnce()
    {
        currentFill += fillSpeed * Time.deltaTime;
        currentFill = Mathf.Clamp01(currentFill);

        fillBar.fillAmount = currentFill;
    }
}
