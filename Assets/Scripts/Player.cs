using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 inputVector;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed = 10f;
    bool isWalking = false;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementHandle();
    }

    private void MovementHandle()
    {
        inputVector = GameInput.Instance.GetInputVectorNormalized();

        Vector3 moveDir = inputVector;

        float moveStep = speed * Time.deltaTime;
        float playerRadius = 2f;
        bool canMove = !Physics2D.CircleCast(transform.position, playerRadius, moveDir, moveStep);

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
        // Debug.Log(canMove);
        if(canMove) {
            transform.position += moveDir * moveStep;
        }

        isWalking = moveDir != Vector3.zero;
        transform.up = Vector3.Slerp(transform.up, moveDir, Time.deltaTime * rotationSpeed);

    }

    public bool IsWalking(){
        return isWalking;
    }

   
}
