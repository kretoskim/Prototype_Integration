using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private GameObject introMenu;
    [SerializeField] private GameObject settingsMenu;
    private string gameSceneName = "GameScene";

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
            playButton.onClick.AddListener(StartGame);
        }
        if(settingsButton != null)
        {
            settingsButton.onClick.AddListener(ShowOptions);
        }
    }

    private void OnDisable()
    {
        if(playButton != null)
        {
            playButton.onClick.RemoveListener(StartGame);
        }
        if(settingsButton != null)
        {
            settingsButton.onClick.RemoveListener(ShowOptions);
        }
    }
    private void StartGame()
    {
       SceneManager.LoadScene(gameSceneName);
    }

    private void ShowOptions()
    {
        introMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
