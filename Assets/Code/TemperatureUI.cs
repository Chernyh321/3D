using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TemperatureUI : MonoBehaviour
{
    public  Health health;
    public int playerDamage=2;
    public float tempetatureCurrent = 36.6f;
    public float tempetatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public float freezeSpeed = 0.05f;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;
    public float temperature;

    void Update()
    {
        
        if (tempetatureCurrent <= temperatureCritical) 
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;

            }

        }
        Mathf.Round(temperature * 10.0f)* 0.1f


    }
}
