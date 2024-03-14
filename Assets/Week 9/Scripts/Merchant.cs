using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : Villager
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destination = transform.position;
        animator = GetComponent<Animator>();
    }
}
