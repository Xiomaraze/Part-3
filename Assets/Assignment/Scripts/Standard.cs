using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Standard : MonoBehaviour
{
    float hp = 50;
    static float hpMax = 50;
    float reflect = 2;
    float hpRegen = 0;
    bool dead = false;
    bool hit = false;
    Animator anim;
    Rigidbody2D rigBody;
    CapsuleCollider2D capCol;
    public DummyBar curBar;
    public Player player;

    Coroutine Regen;
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        capCol = GetComponent<CapsuleCollider2D>();
        Regen = StartCoroutine(HealthRegen(hpRegen));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hit == true)
        {
            //do the thing with the damage
            hit = false;
        }
        if (dead == true)
        {
            //send message back to spawner to spawn new one
            //destroy prefab
        }
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        else
        {
            Damaged(player.DPS);
            hit = true;
        }
    }

    private void OnMouseUp()
    {
        hit = false;
    }

    static public void DisplayHP()
    {

    }

    void Damaged(float dmg)
    {
        if (dead) //leave function if dead
        {
            return;
        }
        hp -= dmg;
        hp = Mathf.Clamp(hp, 0, hpMax);
        Reflect(reflect);
        // do something with the animator here to show the damage 
        if (hp <= 0)
        {
            dead = true;
        } // mark dead if hp drops to or bellow 0
    }

    void Reflect(float thorn)
    {
        player.SendMessage("TakeDmg", thorn);
    }
    IEnumerator HealthRegen(float regen)
    {
        while (dead == false) {
            hp += regen;
            yield return new WaitForSecondsRealtime(1);
        }
    }

}
