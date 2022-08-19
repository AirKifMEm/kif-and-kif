using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [Header("Var's")]
    public float Up;
    public float X;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
           other.transform.position = new Vector3(other.transform.position.x + X, other.transform.position.y + Up, other.transform.position.z);
        if (other.gameObject.tag == "Enemy")
            other.transform.position = new Vector3(other.transform.position.x + X, other.transform.position.y + Up, other.transform.position.z);
    }
}
