using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGuns : MonoBehaviour
{
    public static bool ak = false;
    public static bool pistol = false;
    public static bool snip = false;
    public static bool mg = false;
    public static bool rl = false;
    public static bool uzi = false;

    [Header("Close Image")]
    public GameObject im1;
    public GameObject im2;
    public GameObject im3;
    public GameObject im4;
    public GameObject im5;
    public GameObject im6;

    void Start()
    {
        if (ak)
        {
            Destroy(im1);
        }
        if (pistol)
        {
            Destroy(im2);
        }
        if (snip)
        {
            Destroy(im3);
        }
        if (mg)
        {
            Destroy(im4);
        }
        if (rl)
        {
            Destroy(im5);
        }
        if (uzi)
        {
            Destroy(im6);
        }
    }
}
