using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private int amount;

    

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            other.GetComponentInParent<Inventory>().AddItem(new Item(itemSO, amount));
        }
    }
}
