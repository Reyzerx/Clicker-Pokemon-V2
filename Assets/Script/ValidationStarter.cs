using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValidationStarter : MonoBehaviour
{
    public TextMeshProUGUI textStatspoke;
    public Image sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void afficherStats()
    {
        sprite.sprite = SaveData.dataStatic.starter.sprite;
        textStatspoke.text = "nom = " + SaveData.dataStatic.starter.nom
            + "\n niveau = " + SaveData.dataStatic.starter.niveau
            + "\n degat = " + SaveData.dataStatic.starter.degat
            + "\n exp = " + SaveData.dataStatic.starter.exp
            + "\n type = " + SaveData.dataStatic.starter.type[0]
            + "\n estStocker = " + SaveData.dataStatic.starter.estStocker
            + "\n estEquipe = " + SaveData.dataStatic.starter.estEquipe
            + "\n estShop = " + SaveData.dataStatic.starter.estShop
            + "\n estSauvage = " + SaveData.dataStatic.starter.estSauvage;
    }
}
