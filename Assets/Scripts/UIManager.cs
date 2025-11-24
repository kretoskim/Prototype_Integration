using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIProgressBar progressBar;
    [SerializeField] private PlayerInput playerInput;

    private void OnEnable()
    {
        if(playerInput == null)
        {
            Debug.LogWarning("UIManager: playerInput not assigned");
        }
        playerInput.OnInteract += HandleInteract;        
    }
    private void OnDisable()
    {
        if(playerInput != null)
        {
          playerInput.OnInteract -= HandleInteract;  
        }
        
    }

    private void HandleInteract()
    {
        progressBar.FillOnce();
    }
}
