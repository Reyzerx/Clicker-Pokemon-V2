using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static Data data = new Data();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveToJson();
            Debug.Log("Save");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadFromJson();
            Debug.Log("Load");
            Debug.Log(data.starter.nom);
        }
    }

    public void SaveToJson()
    {
        string saveData = JsonUtility.ToJson(data);
        string filePath = Application.persistentDataPath + "/SaveData.json";
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, saveData);
    }

    public void LoadFromJson()
    {
        string filePath = Application.persistentDataPath + "/SaveData.json";
        string saveData = System.IO.File.ReadAllText(filePath);

        data = JsonUtility.FromJson<Data>(saveData);
    }
}

[System.Serializable]
public class Data
{
    //Player Save
    [SerializeField]
    public Pokemon starter;

}
