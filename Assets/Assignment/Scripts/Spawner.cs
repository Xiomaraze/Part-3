using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject standardDummy;
    public GameObject healerDummy;
    public GameObject damageDummy;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNew();
    }

    public void DummyDestroyed()
    {

    }

    void SpawnNew()
    {
        int tossUp = Random.Range(1, 4);
        if (tossUp == 1)
        {
            Instantiate(standardDummy);
        }
        else if (tossUp == 2)
        {
            Instantiate(healerDummy);
        }
        else
        {
            Instantiate(damageDummy);
        }
    }
}
