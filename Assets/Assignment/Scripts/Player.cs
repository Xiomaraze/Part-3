using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float playerHealth;
    float playerMaxHealth;
    public float DPS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void TakeDmg(float dmg)
    {
        playerHealth -= dmg;
        if (playerHealth < 0)
        {
            //game over here
        }
    }

    void Heal()
    {
        playerHealth = playerMaxHealth;
    }
}
