using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator animator;
    public enum ChestType {villager, merchant, archer};
    public ChestType type;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Villager npc))
        {
            Villager objScript = collision.GetComponent<Villager>();
            ChestType objType = (ChestType)objScript.CanOpen();
            Debug.Log(objType);
            if (objType == type)
            {
                animator.SetBool("IsOpened", true);
            }
            else if (type == ChestType.villager)
            {
                animator.SetBool("IsOpened", true);
            }
            else { }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
