using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemy_base : MonoBehaviour
{

    public int Heals = 100;
    
    public int moneydrop;

    //StartMovevar
    private Transform target;
    public float seeDistance = 5f;
    public float attackDistance = 2f;
    public float speed = 6;

    //moveVar
    private bool Right;
    private float vect;

    //PlayerDmgVar
    public bool pher;
    public int dmg;
    
    public GameObject self;
    public GameObject coin;
    private int chance;
    //move
    void Start()
    {
        InvokeRepeating("PlayerDMG", 2f, 1f);
        target = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
            {
                //walk
                // transform.LookAt(target.transform);
                //transform.localEulerAngles = new Vector3(0, 0, 0);
                //self.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                  if (vect > transform.position.x && Right)
                    {
                        Vector3 Scaler = transform.localScale;
                        Scaler.x *= -1;
                        transform.localScale = Scaler;
                        Right = false;

                    }
                    if (vect < transform.position.x && !Right)
                    {
                        Vector3 Scaler = transform.localScale;
                        Scaler.x *= -1;
                        transform.localScale = Scaler;
                        Right = true;
                    }
               
                

                vect = transform.position.x;
            }
        }
        else
        {
            //idle
        }
        if (Vector3.Distance(transform.position, target.transform.position) < attackDistance)
        {
            pher = true;
        }
        else
        {
            pher = false;
        }



    }

    public void GetDamage()
    {
        Heals = Heals - Bullets.dmg;
        if (Heals <= 0)
        {
            Destroy(self);

            chance = Random.Range(1, 3);
            if (chance == 1)
            {
                player.coins = player.coins + moneydrop;
               // Vector3 spawn = new Vector3(self.transform.position.x, self.transform.position.y, self.transform.position.z);
               // Instantiate(coin, spawn, Quaternion.identity);
            }
        }
    }
    // Player Dmg 
    public void PlayerDMG()
    {
        if (pher)
        {
        player.heals = player.heals - dmg;
        }
    }
}
