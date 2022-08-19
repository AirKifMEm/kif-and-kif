using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class RandLevelChose : MonoBehaviour
{
    [Header("Level's")]
    public GameObject I;
    public GameObject II;
    public GameObject III;
    public GameObject IV;

    [Header("Player")]
    public GameObject player;
    public Camera camera;

    private int chance;

    public void Start()
    {
        chance = Random.Range(1, 5);

        if(chance == 1)
        {
            player.transform.position = new Vector3(I.transform.position.x, I.transform.position.y, I.transform.position.z);
            camera.transform.position = new Vector3(I.transform.position.x, I.transform.position.y, I.transform.position.z);
        }
        if (chance == 2)
        {
            player.transform.position = new Vector3(II.transform.position.x, II.transform.position.y, II.transform.position.z);
            camera.transform.position = new Vector3(II.transform.position.x, II.transform.position.y, II.transform.position.z);
        }
        if (chance == 3)
        {
            player.transform.position = new Vector3(III.transform.position.x, III.transform.position.y, III.transform.position.z);
            camera.transform.position = new Vector3(III.transform.position.x, III.transform.position.y, III.transform.position.z);
        }
        if (chance == 4)
        {
            player.transform.position = new Vector3(IV.transform.position.x, IV.transform.position.y, IV.transform.position.z);
            camera.transform.position = new Vector3(IV.transform.position.x, IV.transform.position.y, IV.transform.position.z);
        }
    }
}
