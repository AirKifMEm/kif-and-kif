using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject[] Spawnpoint;
    public int numberofspawn;

    void Start()
    {
        for (int i = 0; i < numberofspawn; i++)
        {
           Vector3 point = new Vector3(Spawnpoint[i].transform.position.x, Spawnpoint[i].transform.position.y, Spawnpoint[i].transform.position.z);
            Instantiate(Enemy, point, Quaternion.identity);
        }
    }




}
