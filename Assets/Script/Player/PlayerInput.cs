using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput getPlayerInput;
    public InputSystem inputSystem;
    [HideInInspector] public Vector2 direction = Vector2.zero;
    private void Awake()
    {
        getPlayerInput = this;
        inputSystem = new InputSystem();
        inputSystem.Enable();
        inputSystem.Player.Movement.performed += Movement_performed;
        inputSystem.Player.Movement.canceled += Movement_canceled;
    }

    private void Movement_performed(InputAction.CallbackContext value)
    {
        direction = value.ReadValue<Vector2>();
    }
    private void Movement_canceled(InputAction.CallbackContext value)
    {
        direction = Vector2.zero;
    }
}
