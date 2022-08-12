using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRes : MonoBehaviour
{
    [Header("Resourse")]
    public static int money;
    public static int ener;
    public static int diam;

    [Header("Level value")]
    public Slider slider;
    public  static float exp;
    public  static int level;



    [Header("Text's")]
    public Text dia;
    public Text mon;
    public Text ene;
    public Text levels;

  

    void Update()
    {
        
        slider.value = exp;
        dia.text = diam.ToString();
        mon.text = money.ToString();
        ene.text = ener.ToString();
        levels.text = level.ToString();

        //new level
        if(exp >= 1)
        {
            exp = 0;
            level = level + 1;
        }


    }

}
