using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public Health health;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    public CoinsCounter coinsCounter;

    void Update()
    {
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.health;
        coinsCounterText.text = coinsCounter.coins.ToString();


    }
}
