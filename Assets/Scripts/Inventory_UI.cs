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

    public void RefreshInventoryItem() {

        foreach (Transform child in itemSlotCointainer){
            if (child == itemSlotTemplate) continue;
            else Destroy(child.gameObject);
        }

        foreach (Item item in inventory.GetItemList()){
            Transform spawnedMission = Instantiate(itemSlotTemplate, itemSlotCointainer);
            spawnedMission.gameObject.SetActive(true);
            spawnedMission.GetComponent<ItemAsset>().SetItem(item);
        }
    }


}
