using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_ar : MonoBehaviour
{
    public int dmg;
    public float firerate;
    public GameObject fireblast;
    public GameObject bullet;
    public bool seeenemy;

    private void Update()
    {
        while (seeenemy == true)
        {
            Invoke("Fire", 2f);
        }
            
    }
    private void Test()
    {
        Debug.Log("Testing testing testing");
    }
}
