using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, ITakeDamage
{
    private float _currentHealth;
    private float _maxHealth =100;

    public static Action OnDeath;
    private bool _dead;

    public static Action<float> OnDamage;
    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        Debug.Log("AUA" + _currentHealth);

        OnDamage?.Invoke(_currentHealth / _maxHealth);

        if(_currentHealth <=0 && !_dead)
        {
            Die();
        }
    }

    private void Die()
    {
        _dead = true;
        OnDeath?.Invoke();
    }
}
