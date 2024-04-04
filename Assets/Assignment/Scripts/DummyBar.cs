using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyBar : MonoBehaviour
{
    public Slider hpBar;

    public void Damaged(float dmg)
    {
        hpBar.value -= dmg;
    }
}
