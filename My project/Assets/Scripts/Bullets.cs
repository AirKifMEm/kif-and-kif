using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
  
    public float speed = 1000f;
    
    private Rigidbody2D rigidBody;

    public GameObject self;

    public static int dmg;

    public int Damage;



    void Start()
    {

        dmg = Damage;

        if (player.facingRight == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(speed, 0, 0);
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-speed, 0, 0);
        }

        Invoke("Dead", 4f);
    }
    void Dead()
    {
        Destroy(self);
    }









}
