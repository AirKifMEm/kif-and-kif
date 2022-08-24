using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventData : MonoBehaviour
{
    [Header("Resourse")]
    public static float EXP;
    public static int level = 0;
    private static float value = 1;



    [Header("level Slider's")]
    public Slider[] Sliders;

    [Header("level Text")]
    public Text[] TEXT;

    [Header("Text's")]
    public Text LevelT;
    
    void Update()
    {
        LevelT.text = level.ToString();

        Sliders[level].value = EXP;
        
            if (Sliders[level].value >= value && level < 9)
            {
                TEXT[level].color = new Color(0, 153, 0);
                level = level + 1;
                value = value * 2;
                EXP = 0;

            
            }
        EXP = EXP + 0.01f;

    }
   

    
}
