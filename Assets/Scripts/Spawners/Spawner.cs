using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [field: SerializeField] public int MaxHealth { get; private set; } = 100;
    [field: SerializeField, ReadOnlyInspector] public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void Damage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
    }

    private void OnValidate()
    {
        CurrentHealth = MaxHealth;
    }
}
