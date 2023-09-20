using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 inputVector;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private LayerMask _interactableLayer;
    [SerializeField] private LayerMask _playerLayer;
    bool isWalking = false;
    bool isAttacking = false;
    PlayerAnimatorControl _animationController;
    private Inventory _inventory;

    
    private void Awake() {
        _animationController = GetComponent<PlayerAnimatorControl>();
        _inventory = new Inventory();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameInput.Instance.OnInteractionAction += GameInput_OnInteractionAction;
        GameInput.Instance.OnAttackAction += GameInput_OnAttackAction;
    }

    private void GameInput_OnAttackAction(object sender, EventArgs e)
    {
        _animationController.TriggerAttack();
    }


    // Update is called once per frame
    void Update()
    {
        MovementHandle();
        InteractionHandle();
        InventoryHandle();
    }

    private void InventoryHandle()
    {
        
    }

    void InteractionHandle(){
        inputVector = GameInput.Instance.GetInputVectorNormalized();

        Vector3 moveDir = inputVector;
        // float checkDistance = 1f;
        // RaycastHit2D hit2D = Physics2D.Raycast(transform.position, moveDir, checkDistance, _interactableLayer);

        // if(hit2D) {
        //     //Hit something
        //     if(hit2D.transform.TryGetComponent(out Interactable interactable)) {
        //         if(interactable != selectedInteractItem) {
        //             SetSelectedInteractItem(interactable);
        //         }
        //     }
        //     else {
        //         SetSelectedInteractItem(null);
        //     }
        // }
        // else {
        //     SetSelectedInteractItem(null);
        // }


    }
    private void MovementHandle()
    {
        inputVector = GameInput.Instance.GetInputVectorNormalized();

        Vector3 moveDir = inputVector;

        float moveStep = speed * Time.deltaTime;
        float playerRadius = 1f;
        bool canMove = !Physics2D.CircleCast(transform.position, playerRadius, moveDir, moveStep, ~_playerLayer);

        if(!canMove) {
            Vector2 moveDirX = new Vector2(moveDir.x, 0).normalized;
            canMove = (moveDirX.x < -0.5f || moveDirX.x > 0.5f) && !Physics2D.CircleCast(transform.position, playerRadius, moveDirX, moveStep);
            if(canMove) {
                moveDir = moveDirX;
            }
            else{
                Vector2 moveDirY = new Vector2 (0, moveDir.y).normalized;
                canMove = (moveDirY.y < -0.5f || moveDirY.y >  0.5f) && !Physics2D.CircleCast(transform.position, playerRadius, moveDirY, moveStep);
                if(canMove) {
                    moveDir = moveDirY;
                }
                else{
                    // Cannot move in any direction
                }
            }
        }

        if(canMove) {
            transform.position += moveDir * moveStep;
        }

        isWalking = moveDir != Vector3.zero;
        transform.up = Vector3.Slerp(transform.up, moveDir, Time.deltaTime * rotationSpeed);

    }

    private void GameInput_OnInteractionAction(object sender, EventArgs e)
    {
      
    }

    public bool IsWalking(){
        return isWalking;
    }

    public bool IsAttacking(){
        return isAttacking;
    }

   
    


 }

   