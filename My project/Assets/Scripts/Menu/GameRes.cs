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
    public Slider sliderlvl;
    public  static float exp;
    public  static int level;

    [Header("Enerhy value")]
    public Slider slider_ener;
    
    


    [Header("Text's")]
    public Text dia;
    public Text mon;
    public Text ene;
    public Text levels;

    public static int CurrentGun;

  

    void Update()
    {
        slider_ener.value = ener;
        sliderlvl.value = exp;
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
