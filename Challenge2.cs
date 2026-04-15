using System;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;

    private bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;   
    }


    // Update is called once per frame
    void Update()
    {
        if (isDead) return;

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Heal(10);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TakeDamage(20);
        }
    }

   

    void Heal(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        Debug.Log("Youre Healed! Your Current Health Is: " + currentHealth);
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth < 0)
        {
            currentHealth = 0;
        }

        Debug.Log("Youve taken Damage! Current Health Is: " + currentHealth);

        if (currentHealth == 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Debug.Log("You Have Died.");
    }
}
