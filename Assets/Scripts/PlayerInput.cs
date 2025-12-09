using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputActions inputActions;
    public event Action OnInteractStarted;
    public event Action OnInteractCanceled;

    
    //Public property for continous movement
    public Vector2 MovementInput { get; private set; }

    private void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        //Subscribe to movement input events
        inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Move.canceled += OnMove;

        inputActions.Player.Interact.started += OnInteractStartedCallback;
        inputActions.Player.Interact.canceled += OnInteractCanceledCallback;
        

        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        //Unsubscribe
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Move.canceled -= OnMove;

        inputActions.Player.Interact.started -= OnInteractStartedCallback;
        inputActions.Player.Interact.canceled -= OnInteractCanceledCallback;
        
        inputActions.Player.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
    }
    private void OnInteractStartedCallback(InputAction.CallbackContext context)
    {
        OnInteractStarted?.Invoke();
    }
    private void OnInteractCanceledCallback(InputAction.CallbackContext context)
    {
        OnInteractCanceled?.Invoke();
    }   
}
