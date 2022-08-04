using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZOne : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                player.heals = player.heals - 200;
            }
        }
    
}
