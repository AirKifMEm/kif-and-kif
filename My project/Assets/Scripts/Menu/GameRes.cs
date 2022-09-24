using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameRes : MonoBehaviour
{
    [Header("Resourse")]
    public static int money;
    public static float ener;
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
    public static int rebith;
  
    void Start()
    {
        if (rebith == 1)
        {
            levels.color = new Color(146, 146, 146);
        }
        CalculateOfflineIcome();

    }
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
            diam = diam + level;
        }
        //100 level Upgrade
        if(level > 99)
        {
            level = 0;
            rebith = rebith + 1;
        }


    }


    //sub proc's
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("LastPlayedTime", DateTime.UtcNow.ToString());
    }
    private void CalculateOfflineIcome()
    {
        string lastPlayedTimeString =PlayerPrefs.GetString("LastPlayedTime", null);

        if (lastPlayedTimeString == null)
            return;

        var lastPlayedTime = DateTime.Parse(lastPlayedTimeString);
        int timeSpanRestriction = 24 * 60 * 60;
        double secondSpan = (DateTime.UtcNow - lastPlayedTime).TotalSeconds;

        if (secondSpan > timeSpanRestriction)
            secondSpan = timeSpanRestriction;
        ener = ener + (float)secondSpan / 60 / 5;
        if (ener > 100)
        {
            ener = 100;
        }
    }

}
