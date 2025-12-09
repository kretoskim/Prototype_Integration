using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.InputSystem;

public class UIProgressBar : MonoBehaviour
{
    [SerializeField] private Image fillBar; 
    private float currentFill = 0f;

    private void Awake()
    {
        if(fillBar == null)
        {
            fillBar = GetComponent<Image>();
        }
        //start empty
        currentFill = 0f;        
    }
    private void Update()
    {
        
    }
    public void FillOnce()
    {
        currentFill += Time.deltaTime;
        currentFill = Mathf.Clamp01(currentFill);

        fillBar.fillAmount = currentFill;
    }
}
