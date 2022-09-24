using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClaimRewardsButton : MonoBehaviour
{

    public Button[] RewardButton;
    public int ButtonN;

    [Header("Rewards")]
    public int[] Diam;
    public int[] Energy;
    public int[] Money;


    void Update()
    {
        ButtonN = EventData.level - 1;
        Onclick();
    }

    public void Onclick()
    {

        if(ButtonN <= EventData.level)
        {
            if (ButtonN == 1)
            {

            }
        }

    }
}
