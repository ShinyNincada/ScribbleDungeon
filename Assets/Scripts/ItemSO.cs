using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ItemSO : ScriptableObject
{
    public ItemName itemName;
    public Sprite sprite;
    public ItemType itemType;
    public bool stackable;
}
