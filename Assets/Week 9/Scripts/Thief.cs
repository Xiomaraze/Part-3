using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject dagger;
    Vector2 spawn1;
    Vector2 spawn2;
    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        destination = transform.position;
    }

    public override Enum CanOpen()
    {
        return Chest.ChestType.thief;
    }

    public override void Attack()
    {
        speed = 5;
        spawn1 = new Vector2 (transform.position.x + 1, transform.position.y);
        spawn2 = new Vector2 (transform.position.x - 1, transform.position.y);
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(dagger, spawn1, Quaternion.identity);
        Instantiate(dagger, spawn2, Quaternion.identity);
        base.Attack();
        speed = 3;
    }
}
