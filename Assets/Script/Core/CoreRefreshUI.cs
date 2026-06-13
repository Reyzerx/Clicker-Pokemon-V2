using UnityEngine;
using TMPro;
using System.Text;
using UnityEngine.UI;

public class CoreRefreshUI : MonoBehaviour
{
    public GameObject sceneStarter;
    public GameObject sceneJeu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneJeu.SetActive(false);
        sceneStarter.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void afficherSceneJeu(bool afficherSceneIn)
    {
        sceneJeu.SetActive(afficherSceneIn);
        sceneStarter.SetActive(!afficherSceneIn);
    }

    public void afficherSceneStarter(bool afficherSceneIn)
    {
        sceneStarter.SetActive(afficherSceneIn);
        sceneJeu.SetActive(!afficherSceneIn);
    }
}
