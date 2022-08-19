using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_coins : MonoBehaviour
{
    public GameObject self;
    public int money;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(self);
            player.coins = player.coins + money;


        }
    }

}
