using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Spawner : MonoBehaviour
{
    [field: SerializeField] public int MaxHealth { get; private set; } = 100;
    [field: SerializeField, ReadOnlyInspector] public int CurrentHealth { get; private set; }

    [Space]
    [SerializeField] TMP_Text healthText;


    private void Awake()
    {
        CurrentHealth = MaxHealth;

        healthText.text = CurrentHealth + "/" + MaxHealth;
    }

    public void Damage(int damageAmount)
    {
        CurrentHealth -= damageAmount;

        healthText.text = CurrentHealth + "/" + MaxHealth;
    }

    private void OnValidate()
    {
        CurrentHealth = MaxHealth;

        if(healthText != null)
        healthText.text = CurrentHealth + "/" + MaxHealth;
    }
}
