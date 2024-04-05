using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Healer : Standard
{
    Coroutine Regen;
    // Start is called before the first frame update
    void Start()
    {
        hpRegen = 1;
        spawnScript = spawner.GetComponent<Spawner>();
        Regen = StartCoroutine(HealthRegen(hpRegen));
    }
    protected override void Damaged(float dmg)
    {
        base.Damaged(dmg);
        Sorry();
    }


    private void Sorry () //this only exists on the healer class objects
    {
        Debug.Log("My health is " + hp + " regenerating at 1 per second.");
    }
    IEnumerator HealthRegen(float regen) //got this sucker to work!
    {
        while (true)
        {
            hp += regen;
            curBar.Hit(-regen);
            yield return new WaitForSeconds(1);
        }
    }
}
