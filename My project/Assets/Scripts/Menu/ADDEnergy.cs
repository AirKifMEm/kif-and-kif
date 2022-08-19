using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADDEnergy : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("ADD", 1f, 60f);
    }
    private void ADD()
    {
        if (GameRes.ener < 100)
        {
            GameRes.ener = GameRes.ener + 1;
        }
    }
}
