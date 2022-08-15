using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_ar : MonoBehaviour
{
    public int dmg;
    public float firerate;
    public GameObject fireblast;
    public GameObject bullet;
    public bool seeenemy = false;

    private void Start()
    {
        InvokeRepeating("Fire", 1f, firerate);
    }
    private void Update()
    {
        if (seeenemy == true)
        {
            fireblast.SetActive(true);
        }
        else
        {
            fireblast.SetActive(false);
        }
    }
    private void Fire()
    {
        if (seeenemy == true)
        {
            Vector3 spawn = new Vector3(fireblast.transform.position.x, fireblast.transform.position.y, fireblast.transform.position.z);
            
            Instantiate(bullet, spawn, Quaternion.identity);


        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            seeenemy = true;
        }
            
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            seeenemy = false;
        }

    }
}
