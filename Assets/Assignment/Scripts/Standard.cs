using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Standard : MonoBehaviour
{
    public float hp = 50;
    protected static float hpMax = 50;
    protected float hpRegen = 0;
    protected bool dead = false;
    bool hit = false;
    Animator anim;
    Rigidbody2D rigBody;
    CapsuleCollider2D capCol;
    public DummyBar curBar;
    public GameObject spawner;
    protected Spawner spawnScript;

    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        capCol = GetComponent<CapsuleCollider2D>();
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
            spawnScript.DummyDestroyed();
            //destroy prefab
            Destroy(gameObject);
        }
    }

    protected virtual void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        else
        {
            Damaged(spawnScript.DPS);
            hit = true;
            curBar.Hit(spawnScript.DPS);
            //Debug.Log(PCscript.DPS);
        }
    }

    protected virtual void OnMouseUp()
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

}
