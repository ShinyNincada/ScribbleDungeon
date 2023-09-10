using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : Interactable
{
    public override void Interact(Player player)
    {
        base.Interact(player);

        Pickup();
    }

    void Pickup(){
        Debug.Log("Picking up!!");
        
    }
}
