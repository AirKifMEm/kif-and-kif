using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemy_base : MonoBehaviour
{

    public float speed;

    private float waitTime;

    public float startWaitTime;

    public Transform[] moveSpot;
    private bool ismoveleft = true;
    private int randomSpot;

    public int Heals = 100;
    
    public GameObject self;
    public GameObject coin;
    private int chance;
    public int moneydrop;

    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpot.Length);
        
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                if (moveSpot.Length == 3)
                {
                    randomSpot = Random.Range(0, moveSpot.Length);
                }
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                waitTime = startWaitTime;

            }
            else
            {
                waitTime -= Time.deltaTime;
            }
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
