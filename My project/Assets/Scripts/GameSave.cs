using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class GameSave : MonoBehaviour
{
    // public Text text;
    private Data data = new Data();

    public class Data
    {
        public int money;
        public int ener;
        public int diam;
    }

    public void SaveGame()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/Save"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Save");
        }

        data.money = GameRes.money;
        data.ener = GameRes.ener;
        data.diam = GameRes.diam;


        File.WriteAllText(Application.persistentDataPath + "/Save" + "/SaveGame.sv", JsonUtility.ToJson(data));

        Debug.Log("Сохранено успешно");
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/Save" + "/SaveGame.sv"))
        {
            data = JsonUtility.FromJson<Data>(File.ReadAllText(Application.persistentDataPath + "/Save" + "/SaveGame.sv"));

            Debug.Log("Сохранение загружено");
        }

        else if (!File.Exists(Application.persistentDataPath + "/Save" + "/SaveGame.sv"))
        {
            Debug.Log("сохранение не найдено!");
        }

        GameRes.money = data.money;
        GameRes.ener = data.ener;
        GameRes.diam = data.diam;
    }

    public void Delete()
    {
        if (File.Exists(Application.persistentDataPath + "/Save" + "/SaveGame.sv"))
        {
            File.Delete(Application.persistentDataPath + "/Save" + "/SaveGame.sv");

            Debug.Log("сохранение удалено");
        }

        else if (!File.Exists(Application.persistentDataPath + "/Save" + "/SaveGame.sv"))
        {
            Debug.Log("Сохранений нет");
        }
    }

    



}
