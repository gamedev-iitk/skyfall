﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_oxygen : MonoBehaviour
{
	public int maxHealth = 5000;
	public int currentHealth;

	public Oxygen_Bar oxygenBar;

    // Start is called before the first frame update
    void Start()
    {
     	currentHealth = maxHealth;
     	oxygenBar.SetMaxHealth(maxHealth);   
    }

    // Update is called once per frame
    void Update()
    {
        TakeDamage(1);
    }

    void TakeDamage(int damage)
    {
    	currentHealth -= damage;

    	oxygenBar.SetHealth(currentHealth);
    }
}
