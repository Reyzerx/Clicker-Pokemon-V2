using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static Data dataStatic = new Data();
    public Data data;

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

        data = dataStatic;
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

        setAllDataFromLoad(data);
    }

    public void setAllDataFromLoad(Data data)
    {
        
    }
}

[System.Serializable]
public class Data
{
    //Player Save
    [SerializeField]
    public Pokemon starter;

    public List<Pokemon> equipePokemonJoueur;
    public List<Pokemon> stockagePokemonJoueur;
}
