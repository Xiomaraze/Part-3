using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : Standard
{
    // Start is called before the first frame update
    void Start()
    {
        reflect = 3;
    }

    void Reflected(float thorns)
    {
        player.SendMessage("TakeDmg", thorns);
    }

    protected override void Damaged(float dmg)
    {
        base.Damaged(dmg);
        Reflected(reflect);
    }
}
