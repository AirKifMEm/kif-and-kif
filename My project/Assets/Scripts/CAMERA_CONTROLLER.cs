using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA_CONTROLLER : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;


    private void Awake()
    {
        if (!player)
            player = FindObjectOfType<player>().transform;
    }
    private void Update()
    {
        pos = player.position;
        pos.z = -10f;

        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);

    }
}
