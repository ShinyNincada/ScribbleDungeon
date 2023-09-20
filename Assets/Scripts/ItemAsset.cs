using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAsset : MonoBehaviour
{
    [SerializeField] private Image _renderer;
    Item _item;

    
    public void SetItem(Item item){
        this._item = item;
        _renderer.sprite = _item.itemSO.sprite;
    }
}
