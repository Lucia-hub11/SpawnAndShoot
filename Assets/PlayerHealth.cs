using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, ITakeDamage
{
    private float _currentHealth;
    private float _maxHealth =100;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public void TakeDamage(float amount)
    {
        Debug.Log("AUA" + _currentHealth);
    }
}
