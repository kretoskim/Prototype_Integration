using UnityEngine;
using UnityEngine.UI;

public class UIProgressBar : MonoBehaviour
{
    [SerializeField] private Image fillBar; 
    [SerializeField] private float fillSpeed = 5f;
    private float currentFill = 0f;
    private bool isFilling = false;

    private void Awake()
    {
        if(fillBar == null)
        {
            fillBar = GetComponent<Image>();
        }
        //start empty
        fillBar.fillAmount = 0f;        
    }
    private void Update()
    {
        if(isFilling)
        {
            currentFill += fillSpeed * Time.deltaTime;
            currentFill = Mathf.Clamp01(currentFill);
            fillBar.fillAmount = currentFill;
        }
    }
    public void StartFilling()
    {
        isFilling = true;
    }
    public void StopFilling()
    {
        isFilling = false;
    }
}
