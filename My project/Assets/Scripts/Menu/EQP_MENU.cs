using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EQP_MENU : MonoBehaviour
{
    [Header("Image Current Gun")]
    public GameObject pistol;
    public GameObject uzi;
    public GameObject rl;
    public GameObject ak;
    public GameObject mg;
    public GameObject snip;

    public int GunN;

    void Start()
    {
        
        if (GameRes.CurrentGun == 1)
        {
            ak.SetActive(true);
           
           
        }
        if (GameRes.CurrentGun == 2)
        {
            pistol.SetActive(true);
           
            
        }
        if (GameRes.CurrentGun == 3)
        {
            uzi.SetActive(true);
          
            
        }
        if (GameRes.CurrentGun == 4)
        {
            snip.SetActive(true);
            
           
        }
        if (GameRes.CurrentGun == 5)
        {
            mg.SetActive(true);
           
        }

        if (GameRes.CurrentGun == 6)
        {
            rl.SetActive(true);
           
        }
    }

    public void OnMouseDown()
    {

        if (GunN == 1)
        {
            ak.SetActive(true);
            GameRes.CurrentGun = 1;
            rl.SetActive(false);
            pistol.SetActive(false);
            uzi.SetActive(false);
            mg.SetActive(false);
            snip.SetActive(false);
        }
        if (GunN == 2)
        {
            pistol.SetActive(true);
            GameRes.CurrentGun = 2;
            rl.SetActive(false);
            ak.SetActive(false);
            uzi.SetActive(false);
            mg.SetActive(false);
            snip.SetActive(false);
        }
        if (GunN == 3)
        {
            uzi.SetActive(true);
            GameRes.CurrentGun = 3;
            rl.SetActive(false);
            ak.SetActive(false);
            pistol.SetActive(false);
            mg.SetActive(false);
            snip.SetActive(false);
        }
        if (GunN == 4)
        {
            snip.SetActive(true);
            GameRes.CurrentGun = 4;
            rl.SetActive(false);
            ak.SetActive(false);
            uzi.SetActive(false);
            mg.SetActive(false);
            pistol.SetActive(false);
        }
        if (GunN == 5)
        {
            mg.SetActive(true);
            GameRes.CurrentGun = 5;
            rl.SetActive(false);
            ak.SetActive(false);
            uzi.SetActive(false);
            pistol.SetActive(false);
            snip.SetActive(false);
        }
   
        if (GunN == 6)
        {
            rl.SetActive(true);
            GameRes.CurrentGun = 6;
            pistol.SetActive(false);
            ak.SetActive(false);
            uzi.SetActive(false);
            mg.SetActive(false);
            snip.SetActive(false);
        }
    } 
}
