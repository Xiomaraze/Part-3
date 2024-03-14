using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public GameObject buton;
    TextMeshProUGUI tmp;
    public static Villager SelectedVillager { get; private set; }

    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

    private void Update()
    {
        tmp = buton.GetComponent <TextMeshProUGUI>();
        string name = string.Empty;
        if (SelectedVillager != null)
        {
            name = SelectedVillager.GetType().Name;
            tmp.SetText(name);
        }
        else
        {
            tmp.SetText (string.Empty);
        }
    }

}
