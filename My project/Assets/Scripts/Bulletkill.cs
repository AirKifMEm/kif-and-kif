using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletkill : MonoBehaviour
{
    public GameObject self;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Enemy")
            {
              Destroy(self);
              other.GetComponent<enemy_base>().GetDamage();
            }
        }
}
