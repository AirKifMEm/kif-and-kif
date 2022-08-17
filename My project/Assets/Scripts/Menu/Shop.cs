using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int ShopN;
    //Money = 1
    //Ener = 2
    //Weapon = 3
    public int BuyN;

    [Header("buy close im")]
    public GameObject im1;
    public GameObject im2;
    public GameObject im3;
    public GameObject im4;
    public GameObject im5;

    public void OnMouseDown()
    {
        if (ShopN == 1)
        {

        }
        if (ShopN == 2)
        {
            if(BuyN == 1 && GameRes.money > 200)
            {
                GameRes.money = GameRes.money - 200;
                GameRes.ener = GameRes.ener + 10;
            }
            if (BuyN == 2 && GameRes.money > 400)
            {
                GameRes.money = GameRes.money - 400;
                GameRes.ener = GameRes.ener + 20;
            }
        }
        if (ShopN == 3)
        {
            if(BuyN == 1 && GameRes.money > 200)
            {
                CloseGuns.ak = true; 
                GameRes.money = GameRes.money - 200;
                im1.SetActive(true);
            }

            if (BuyN == 2 && GameRes.money > 450)
            {
                CloseGuns.uzi = true;
                GameRes.money = GameRes.money - 450;
                im2.SetActive(true);
            }

            if (BuyN == 3 && GameRes.money > 550)
            {
                CloseGuns.snip = true;
                GameRes.money = GameRes.money - 550;
                im3.SetActive(true);
            }

            if (BuyN == 4 && GameRes.money > 700)
            {
                CloseGuns.mg = true;
                GameRes.money = GameRes.money - 700;
                im4.SetActive(true);
            }

            if (BuyN == 5 && GameRes.money > 1000)
            {
                CloseGuns.rl = true;
                GameRes.money = GameRes.money - 1000;
                im5.SetActive(true);
            }
        }
    }

    public void Start()
    {
        if (CloseGuns.ak)
        {
            im1.SetActive(true);
        }
        if (CloseGuns.uzi)
        {
            im2.SetActive(true);
        }
        if (CloseGuns.snip)
        {
            im3.SetActive(true);
        }
        if (CloseGuns.mg)
        {
            im4.SetActive(true);
        }
        if (CloseGuns.rl)
        {
            im5.SetActive(true);
        }
    }
}
