using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider hpBar;
    // Start is called before the first frame update
    public void TakeDMG(float dmg)
    {
        hpBar.value -= dmg;
        Debug.Log(dmg);
    }
}
