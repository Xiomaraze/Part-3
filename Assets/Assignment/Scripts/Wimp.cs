using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wimp : Standard
{
    protected override void Damaged(float dmg) //run twice for flinching
    {
        base.Damaged(dmg);
        base.Damaged(dmg);
    }
}
