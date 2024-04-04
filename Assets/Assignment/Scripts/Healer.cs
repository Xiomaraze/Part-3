using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Standard
{
    // Start is called before the first frame update
    void Start()
    {
        hpRegen = 1;
        reflect = 0;
    }
    protected override void Damaged(float dmg)
    {
        base.Damaged(dmg);
        Sorry();
    }

    private void Sorry () //this only exists on the healer class objects
    {
        Debug.Log("I'm not dead yet.");
    }
}
