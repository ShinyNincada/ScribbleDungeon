using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "MonsterNursery/WeaponSO", order = 0)]
public class WeaponSO : ItemSO {
    public string id;
    public int bulletCount;
    public BulletType bulletType;

    public int damage;
    public float attackSpeed;
    
    public WeaponSO()
    {
        itemType = ItemType.Weapon;
    }
}

public enum BulletType{
    Normal
}