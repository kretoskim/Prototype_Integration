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
        if(playButton != null)
        {
            playButton.onClick.AddListener(ShowOptions);
        }
    }
    private void OnDisable()
    {
        if(playButton != null)
        {
            playButton.onClick.RemoveListener(ShowOptions);
        }
    }

    private void ShowOptions()
    {
        introMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
