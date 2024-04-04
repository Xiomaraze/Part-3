using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standard : MonoBehaviour
{
    float hp = 50;
    float hpMax = 50;
    float reflect = 2;
    float hpRegen = 0;
    bool dead = false;
    Rigidbody2D rigBody;
    CapsuleCollider2D capCol;
    public DummyBar curBar;
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        capCol = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void DisplayHP()
    {

    }

    void Damaged(float dmg)
    {
        if (dead) //leave function if dead
        {
            return;
        }
        hp -= dmg;
        hp = Mathf.Clamp(hp, 0, hpMax);
        if (hp <= 0)
        {
            dead = true;
        } // mark dead if hp drops to or bellow 0
    }
    IEnumerator HealthRegen(float regen)
    {
        while (dead == false) {
            hp += regen;
            yield return null;
        }
    }
}
