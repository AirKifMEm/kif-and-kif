using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemy_base : MonoBehaviour
{

    public int Heals = 100;
    
    public GameObject self;
    public GameObject coin;
    private int chance;
    public int moneydrop;

    private Transform target;
    public float seeDistance = 5f;
    public float attackDistance = 2f;
    public float speed = 6;

    void Start()
    {
        
        target = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
            {
                //walk
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                Vector3 Scaler = transform.localScale;
                Scaler.x *= -1;
                transform.localScale = Scaler;

            }
        }
        else
        {
            //idle
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


}
