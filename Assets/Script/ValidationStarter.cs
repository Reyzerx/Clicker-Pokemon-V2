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
        sprite.sprite = SaveData.data.starter.sprite;
        textStatspoke.text = "nom = " + SaveData.data.starter.nom
            + "\n niveau = " + SaveData.data.starter.niveau
            + "\n degat = " + SaveData.data.starter.degat
            + "\n exp = " + SaveData.data.starter.exp
            + "\n type = " + SaveData.data.starter.type[0]
            + "\n estStocker = " + SaveData.data.starter.estStocker
            + "\n estEquipe = " + SaveData.data.starter.estEquipe
            + "\n estShop = " + SaveData.data.starter.estShop
            + "\n estSauvage = " + SaveData.data.starter.estSauvage;
    }
}
