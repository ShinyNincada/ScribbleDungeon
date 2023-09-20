using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
    [SerializeField] Transform itemSlotCointainer;
    [SerializeField] Transform itemSlotTemplate;
    private Inventory inventory;
    
    public void SetInventory(Inventory inventory){
        this.inventory = inventory;
        RefreshInventoryItem();
    }

    private void RefreshInventoryItem() {
        foreach (Item item in inventory.GetItemList()){
            Transform spawnedMission = Instantiate(itemSlotTemplate, itemSlotCointainer);
            spawnedMission.gameObject.SetActive(true);
            // spawnedMission.GetComponent<SingleDeliveryItemUI>().SetRecipeName(recipe);
        }
    }


}
