using UnityEngine;

public class Core : MonoBehaviour
{

    public Pokemon selectedPokemon;

    public CoreRefreshUI coreRefreshUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Pokemon getSelectedPokemon()
    {
        return selectedPokemon;
    }

    public void setSelectedPokemon(Pokemon newValue)
    {
        selectedPokemon = newValue;

        coreRefreshUI.refreshUISelectedPokemon(newValue);
    }
}
