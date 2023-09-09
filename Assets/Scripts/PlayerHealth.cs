using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    private void Start() {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <= 0) {
            Dead();
        }
    }

    public void Regen(int amount){
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void Dead(){
        Debug.Log($"{this.name} has been excuted!!");
    }
}
