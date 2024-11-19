using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour, ITakeDamage
{
    public void TakeDamage(float amount)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
