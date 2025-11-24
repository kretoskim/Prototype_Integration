using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 6f;

    private CharacterController controller;
    private PlayerInput playerInput;
    private Vector2 currentInput;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
    }
    private void Update()
    {
        //Read input every frame
        currentInput = playerInput.MovementInput;

        //Apply movement(in 3D)
        Vector3 movement = new Vector3(currentInput.x, 0f, currentInput.y) * moveSpeed *Time.deltaTime;
        controller.Move(movement);
    }
}
