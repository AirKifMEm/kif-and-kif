using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_ar : MonoBehaviour
{
    public int dmg;
    public float firerate;
    public GameObject bullet;
    public GameObject fireblast;

    private void Start()
    {
        Invoke("Test", 5f);
    }
    private void Test()
    {
        Debug.Log("Testing testing testing");
    }
}
