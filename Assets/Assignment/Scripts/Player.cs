using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
//    float playerHealth = 50;
//    static float playerMaxHealth = 50;
    public float DPS;
    SpriteRenderer sprite;
    public Color origColour;
    public Color injured;
    public bool hurt = false;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = origColour;
        }
    }

    private void Update()
    {
        if ((sprite != null) && (hurt == true))
        {
            sprite.color = injured;
        }
        else
        {
            sprite.color = origColour;
        }
    }
}
