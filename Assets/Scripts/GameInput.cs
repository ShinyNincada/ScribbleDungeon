using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public event EventHandler OnInteractionAction;
    public static GameInput Instance { get; private set; }
    public PlayerInput playerInputActions;
    Vector2 inputVector;
    private void Awake() {
        if(Instance == null) {
            Instance = this;
        }
        else {
            Debug.LogWarning($"Another {this.name} is already registered.");
        }

        playerInputActions = new PlayerInput();
        playerInputActions.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        OnInteractionAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetInputVectorNormalized(){
        // inputVector = Vector2.zero;
        inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
