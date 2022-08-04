using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
  
    public float speed = 20f;
    
    private Rigidbody2D rigidBody;

    public GameObject self;

    public int dmg;
    

   
    void Start()
    {
        if (player.facingRight == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(1000, 0, 0);
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-1000, 0, 0);
        }

        Invoke("Dead", 4f);
    }
    void Dead()
    {
        Destroy(self);
    }
   







}
