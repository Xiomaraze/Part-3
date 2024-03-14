using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrow;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        destination = transform.position;
    }

    public override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrow, spawn);
    }
}
