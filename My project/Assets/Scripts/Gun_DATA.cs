using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_DATA : MonoBehaviour
{
    [Header("GUNS")]
    public GameObject ak;
    public GameObject pistol;
    public GameObject uzi;
    public GameObject snip;
    public GameObject mg;
    public GameObject rocketL;
    [Header("arm_socket")]
    public static int GunN;
    public GameObject arm;

    void Start()
    {

        GunN = GameRes.CurrentGun;

        if (GunN == 1) //ak_spawn
        { 
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(ak, spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.23f, prefab.transform.position.z);
        }
        if (GunN == 2) //pistol_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(pistol, spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.1f, prefab.transform.position.z);
        }
        if (GunN == 3) //uzi_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(uzi, spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.23f, prefab.transform.position.z);
        }
        if (GunN == 4) //snip_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(snip, spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.23f, prefab.transform.position.z);
        }
        if (GunN == 5) //mg_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(mg, spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.23f, prefab.transform.position.z);
        }
        if (GunN == 6) //rocketL_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(rocketL, spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.3f, prefab.transform.position.y + 0.33f, prefab.transform.position.z);
        }
    }

}
