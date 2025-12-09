using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private UIProgressBar progressBar;

    private void OnEnable()
    {
        playerInput.OnInteractStarted += progressBar.StartFilling;
        playerInput.OnInteractCanceled += progressBar.StopFilling;
    }
    private void OnDisable()
    {
        playerInput.OnInteractStarted -= progressBar.StartFilling;
        playerInput.OnInteractCanceled -= progressBar.StopFilling;
    }
}
