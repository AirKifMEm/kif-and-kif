using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int ShopN;
    //Money = 1
    //Ener = 2
    //Weapon = 3
    public int BuyN;

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

        }
    }
}
