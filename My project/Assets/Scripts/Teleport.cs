using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public GameObject pointTeleport;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.transform.position = new Vector3(pointTeleport.transform.position.x, pointTeleport.transform.position.y, pointTeleport.transform.position.z);
    }
}
