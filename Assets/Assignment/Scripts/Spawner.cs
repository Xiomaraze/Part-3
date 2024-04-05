using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject standardDummy;
    public GameObject healerDummy;
    public GameObject damageDummy; //deprecated
    public GameObject wimpDummy;
    public float DPS;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNew();
    }

    public void DummyDestroyed()
    {
        SpawnNew();
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
            Instantiate(wimpDummy);
        }
    }
}
