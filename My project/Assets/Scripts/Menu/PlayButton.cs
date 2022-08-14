using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public int LostEnergy;

    public void NextLevel(int _sceneNumber)
    {
        if(GameRes.ener >= LostEnergy)
        {
            GameRes.ener = GameRes.ener - LostEnergy;
            SceneManager.LoadScene(_sceneNumber);
        }
        else
        {
            Debug.Log("NOPE");
        }
    }
}
