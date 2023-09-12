using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandle : MonoBehaviour
{
    [SerializeField] private WeaponSO primaryWeapon;
    [SerializeField] private WeaponSO secondaryWeapon;

    Player _player;

    private void Awake() {
        _player = GetComponent<Player>();
    }
    
    public void AddWeapon(){
        
    }
}
