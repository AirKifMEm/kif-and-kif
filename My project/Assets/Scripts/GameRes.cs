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

    

    [Header("Text's")]
    public Text dia;
    public Text mon;
    public Text ene;

    void Update()
    {
      

        dia.text = diam.ToString();
        mon.text = money.ToString();
        ene.text = ener.ToString();


       
    }

}
