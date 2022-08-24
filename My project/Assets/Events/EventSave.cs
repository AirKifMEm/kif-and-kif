using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Collections;


public class EventSave : MonoBehaviour
{
    // public Text text;
    private Data data = new Data();

    public class Data
    {
       
    }

    public void SaveGame()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/Save"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Save");
        }

       

        File.WriteAllText(Application.persistentDataPath + "/Save" + "/Event.sv", JsonUtility.ToJson(data));

        Debug.Log("��������� �������");

       
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/Save" + "/Event.sv"))
        {
            data = JsonUtility.FromJson<Data>(File.ReadAllText(Application.persistentDataPath + "/Save" + "/Event.sv"));

            Debug.Log("���������� ���������");
        }

        else if (!File.Exists(Application.persistentDataPath + "/Save" + "/Event.sv"))
        {
            Debug.Log("���������� �� �������!");
        }

       
    }

    public void Delete()
    {
        if (File.Exists(Application.persistentDataPath + "/Save" + "/Event.sv"))
        {
            File.Delete(Application.persistentDataPath + "/Save" + "/Event.sv");

            Debug.Log("���������� �������");
        }

        else if (!File.Exists(Application.persistentDataPath + "/Save" + "/Event.sv"))
        {
            Debug.Log("���������� ���");
        }
    }
}
