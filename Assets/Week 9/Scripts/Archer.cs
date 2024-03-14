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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrow, spawn);
    }
}
