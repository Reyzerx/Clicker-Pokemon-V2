using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TableType : MonoBehaviour
{
    public List<Sprite> listSpritesForType;

    //0 = aucun
    //x0.5 = faible
    //x1 = normal
    //x2 = fort
    public static string TableDesTypes(string typeAttaque, string typeDefense)
    {
        if(typeDefense == "aucun" || typeDefense == "aucun")
        {
            return "";
        }

        if(typeAttaque == "normal")
        {
            if (typeDefense == "spectre")
            {
                return "aucun";
            }
            if (typeDefense == "roche" || typeDefense == "acier")
            {
                return "faible";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "plante")
        {
            if (typeDefense == "plante" || typeDefense == "feu" || typeDefense == "poison" 
                || typeDefense == "vol" || typeDefense == "insecte" || typeDefense == "dragon" 
                || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "eau" || typeDefense == "sol" || typeDefense == "roche")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "feu")
        {
            if (typeDefense == "feu" || typeDefense == "eau" || typeDefense == "roche"
                || typeDefense == "dragon")
            {
                return "faible";
            }
            if (typeDefense == "plante" || typeDefense == "glace" || typeDefense == "insecte"
                || typeDefense == "acier")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "eau")
        {
            if (typeDefense == "plante" || typeDefense == "eau" || typeDefense == "dragon" || typeDefense == "electrik")
            {
                return "faible";
            }
            if (typeDefense == "feu" || typeDefense == "sol" || typeDefense == "roche")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "electrik")
        {
            if (typeDefense == "sol")
            {
                return "aucun";
            }
            if (typeDefense == "plante" || typeDefense == "electrik" || typeDefense == "dragon")
            {
                return "faible";
            }
            if (typeDefense == "eau" || typeDefense == "vol")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "glace")
        {
            if (typeDefense == "feu" || typeDefense == "eau" || typeDefense == "glace" || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "plante" || typeDefense == "sol" || typeDefense == "vol" || typeDefense == "dragon")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "combat")
        {
            if (typeDefense == "spectre")
            {
                return "aucun";
            }
            if (typeDefense == "poison" || typeDefense == "vol" || typeDefense == "psy" || typeDefense == "insecte")
            {
                return "faible";
            }
            if (typeDefense == "normal" || typeDefense == "glace" || typeDefense == "roche" || typeDefense == "tenebre" || typeDefense == "acier")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "poison")
        {
            if (typeDefense == "acier")
            {
                return "aucun";
            }
            if (typeDefense == "poison" || typeDefense == "sol" || typeDefense == "roche" || typeDefense == "spectre")
            {
                return "faible";
            }
            if (typeDefense == "plante")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "sol")
        {
            if (typeDefense == "vol")
            {
                return "aucun";
            }
            if (typeDefense == "plante" || typeDefense == "psy")
            {
                return "faible";
            }
            if (typeDefense == "feu" || typeDefense == "electrik" || typeDefense == "roche" || typeDefense == "poison" || typeDefense == "acier")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "vol")
        {
            if (typeDefense == "electrik" || typeDefense == "roche" || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "plante" || typeDefense == "combat" || typeDefense == "insecte")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "psy")
        {
            if (typeDefense == "tenebre")
            {
                return "aucun";
            }
            if (typeDefense == "psy" || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "combat" || typeDefense == "poison")
            {
                return "fort";
            }
            return "normal";
        }


        //---------------------------------------------------------------------------------

        else if (typeAttaque == "insecte")
        {
            if (typeDefense == "feu" || typeDefense == "combat" || typeDefense == "poison" 
                || typeDefense == "vol" || typeDefense == "spectre" || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "plante" || typeDefense == "psy" || typeDefense == "tenebre")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "roche")
        {
            if (typeDefense == "combat" || typeDefense == "sol" || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "glace" || typeDefense == "vol" || typeDefense == "insecte")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "spectre")
        {
            if (typeDefense == "normal")
            {
                return "aucun";
            }
            if (typeDefense == "tenebre")
            {
                return "faible";
            }
            if (typeDefense == "psy" || typeDefense == "spectre")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "dragon")
        {
            if (typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "dragon")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "tenebre")
        {
            if (typeDefense == "combat" || typeDefense == "tenebre")
            {
                return "faible";
            }
            if (typeDefense == "psy" || typeDefense == "spectre")
            {
                return "fort";
            }
            return "normal";
        }

        //---------------------------------------------------------------------------------

        else if (typeAttaque == "acier")
        {
            if (typeDefense == "plante" || typeDefense == "feu" || typeDefense == "electrik" || typeDefense == "acier")
            {
                return "faible";
            }
            if (typeDefense == "glace" || typeDefense == "roche")
            {
                return "fort";
            }
            return "normal";
        }

        return "Manquant dans la table des types";
    }


    public static string ResultatTableType(string typeAttaque1, string typeAttaque2, string typeDefense1, string typeDefense2)
    {
        //StringBuilder result2 = new StringBuilder();

        //result2.Append(TableDesTypes(typeAttaque1, typeDefense1) + ";");
        //result2.Append(TableDesTypes(typeAttaque1, typeDefense2) + ";");
        //result2.Append(TableDesTypes(typeAttaque2, typeDefense1) + ";");
        //result2.Append(TableDesTypes(typeAttaque2, typeDefense2));
        //Debug.Log(result2.ToString());

        List<string> result = new List<string>();

        result.Add(TableDesTypes(typeAttaque1, typeDefense1));
        result.Add(TableDesTypes(typeAttaque1, typeDefense2));
        result.Add(TableDesTypes(typeAttaque2, typeDefense1));
        result.Add(TableDesTypes(typeAttaque2, typeDefense2));

        int faible = 0;
        int aucun = 0;
        int normal = 0;
        int fort = 0;

        foreach (string currentResult in result)
        {
            if (currentResult == "faible")
            {
                faible++;
            }
            else if (currentResult == "fort")
            {
                fort++;
            }

            else if (currentResult == "aucun")
            {
                aucun++;
            }
            else if (currentResult == "normal")
            {
                normal++;
            }
        }
        if(aucun > 0)
        {
            return "aucun";
        }
        if(fort > faible && fort >= normal)
        {
            return "fort";
        }
        if (faible > fort && faible >= normal)
        {
            return "faible";
        }
        return "normal";
        
    }

    public Sprite SpriteForType(string type)
    {
        foreach(Sprite currentSprite in listSpritesForType)
        {
            if (currentSprite.name == type)
            {
                return currentSprite;
            }
        }

        return null;
    }
}

