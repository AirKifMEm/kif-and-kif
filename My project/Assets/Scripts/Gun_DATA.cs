using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_DATA : MonoBehaviour
{
    [Header("GUNS")]

    public GameObject[] Guns;

  
    [Header("arm_socket")]
    public static int GunN;
    public GameObject arm;

    void Start()
    {

        GunN = GameRes.CurrentGun;

        if (GunN == 1) //ak_spawn
        { 
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(Guns[0], spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.8f, prefab.transform.position.y - 0.1f, prefab.transform.position.z);
        }
        if (GunN == 2) //pistol_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(Guns[1], spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.1f, prefab.transform.position.z);
        }
        if (GunN == 3) //uzi_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(Guns[2], spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y - 0.1f, prefab.transform.position.z);
        }
        if (GunN == 4) //snip_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(Guns[3], spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.6f, prefab.transform.position.y + 0f, prefab.transform.position.z);
            prefab.transform.Rotate(prefab.transform.rotation.x, prefab.transform.rotation.y, prefab.transform.rotation.z - 10f);
        }
        if (GunN == 5) //mg_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(Guns[4], spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.87f, prefab.transform.position.y + 0.08f, prefab.transform.position.z);
        }
        if (GunN == 6) //rocketL_spawn
        {
            Vector3 spawn = new Vector3(arm.transform.position.x, arm.transform.position.y, arm.transform.position.z);
            GameObject prefab = Instantiate(Guns[5], spawn, Quaternion.identity) as GameObject;
            prefab.transform.SetParent(arm.transform);
            prefab.transform.position = new Vector3(prefab.transform.position.x + 0.25f, prefab.transform.position.y + 0.27f, prefab.transform.position.z);
            prefab.transform.Rotate(prefab.transform.rotation.x, prefab.transform.rotation.y, prefab.transform.rotation.z - 52f);
        }
    }

}
