using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    bool isFocus = false;
   
    public virtual void Interact(Player player){
        Debug.Log("Interactable");
    }

    public virtual void InteractAlternate(Player player){
        Debug.Log("InteractAlternate");
    }

}
