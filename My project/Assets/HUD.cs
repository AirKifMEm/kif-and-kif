using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text heals;
   


    void Update()
    {
        heals.text = player.heals.ToString();
        
    }
}
