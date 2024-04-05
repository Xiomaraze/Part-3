using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : Standard
{
    public float reflect;
    // Start is called before the first frame update
    void Start()
    {
        spawnScript = spawner.GetComponent<Spawner>();
    }

    protected override void Damaged(float dmg)
    {
        base.Damaged(dmg);
    }
}
