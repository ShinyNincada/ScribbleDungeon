using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemAsset : MonoBehaviour
{
    [SerializeField] private Image _renderer;
    [SerializeField] private TMP_Text _amountText;
    Item _item;

    
    public void SetItem(Item item){
        this._item = item;
        _renderer.sprite = _item.itemSO.sprite;
        _amountText.text = _item.amount.ToString();
    }
}
