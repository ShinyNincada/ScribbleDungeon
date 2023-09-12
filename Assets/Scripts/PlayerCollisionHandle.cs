using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandle : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("InventoryPicker")){
            col.TryGetComponent<ItemPicker>(out ItemPicker picker);
            if(!player.GetPickableItems().Contains(picker)) {
                player.AddPickableItem(picker);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col) {
        if(col.CompareTag("InventoryPicker")){
            col.TryGetComponent<ItemPicker>(out ItemPicker picker);
            if(player.GetPickableItems().Contains(picker)) {
                player.RemovePickableItem(picker);
            }
        }
    }

    
}
