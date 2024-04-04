using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Standard : MonoBehaviour
{
    protected float hp = 50;
    protected static float hpMax = 50;
    protected float reflect = 0;
    protected float hpRegen = 0;
    bool dead = false;
    bool hit = false;
    Animator anim;
    Rigidbody2D rigBody;
    CapsuleCollider2D capCol;
    public DummyBar curBar;
    public GameObject player;
    Player PCscript;
    public GameObject spawner;
    Spawner spawnScript;

    Coroutine Regen;
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        capCol = GetComponent<CapsuleCollider2D>();
        Regen = StartCoroutine(HealthRegen(hpRegen));
        PCscript = player.GetComponent<Player>();
        spawnScript = spawner.GetComponent<Spawner>();
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
            spawner.SendMessage("DummyDestroyed");
            //destroy prefab
            Destroy(gameObject);
        }
    }

    protected static void Ouch()
    {
        Debug.Log("Damage sucessfully dealt.");
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        else
        {
            Damaged(PCscript.DPS);
            hit = true;
            Ouch();
        }
    }

    private void OnMouseUp()
    {
        hit = false;
    }

    protected virtual void Damaged(float dmg)
    {
        if (dead) //leave function if dead
        {
            return;
        }
        hp -= dmg;
        hp = Mathf.Clamp(hp, 0, hpMax);
        // do something with the animator here to show the damage 
        if (hp <= 0)
        {
            dead = true;
        } // mark dead if hp drops to or bellow 0
    }
    IEnumerator HealthRegen(float regen)
    {
        while (dead == false) {
            hp += regen;
            yield return new WaitForSecondsRealtime(1);
        }
    }

}
