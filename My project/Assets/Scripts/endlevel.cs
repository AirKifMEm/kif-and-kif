using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{

    public float EndLevelExp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameRes.money = GameRes.money + player.coins;
            GameRes.exp = GameRes.exp + EndLevelExp;
            NextLevel();
        }
    }



    public void NextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
