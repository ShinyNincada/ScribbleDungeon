using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorControl : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    private const string ATTACK_TRIGGER = "Attack";
    private const string WEAPON_KATANA = "Katana";

    Player _player;
    private Animator _animator;

    private void Awake() {
        _animator = GetComponent<Animator>();
        _player = GetComponentInParent<Player>();  
        _animator.SetBool(IS_WALKING,  _player.IsWalking());
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool(IS_WALKING,  _player.IsWalking());
        
    }

    public void TriggerAttack(){
        _animator.SetTrigger(ATTACK_TRIGGER);
    }


}
