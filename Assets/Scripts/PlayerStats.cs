using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] public float maxHealth = 100;
    [SerializeField] public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void ApplyDamage(float damage)
    {
        currentHealth = currentHealth - damage;
    }



  
}
