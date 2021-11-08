using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image health;
    public float currentHealth;
    private float maxHealth = 100f;
    PlayerDamageLevel1 player1;
    PlayerDamage player;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Image>();
        //player1 = FindObjectOfType<PlayerDamageLevel1>();
        player = FindObjectOfType<PlayerDamage>();
    }

    // Update is called once per frame
    void Update()
    {
            currentHealth = player.health;
            health.fillAmount = currentHealth / maxHealth;
        
    }
}
