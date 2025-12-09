using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private GameObject introMenu;
    [SerializeField] private GameObject settingsMenu;

    private void Awake()
    {
        if(introMenu != null)
        {
            introMenu.SetActive(true);
        }
        if(settingsMenu != null)
        {
            settingsMenu.SetActive(false);
        }
    }

    private void OnEnable()
    {
        //subscribe + safety check
        if(playButton != null)
        {
            playButton.onClick.AddListener(OpenSettings);
        }
    }
    private void OnDisable()
    {
        //unsubscribe to prevent memory leaks
        if(playButton != null)
        {
            playButton.onClick.RemoveListener(OpenSettings);
        }
    }

    private void OpenSettings()
    {
        introMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
