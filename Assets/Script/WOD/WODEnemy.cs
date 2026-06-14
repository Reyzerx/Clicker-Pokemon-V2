using UnityEngine;

public class WODEnemy : MonoBehaviour
{
    public MEnemy ui;      // ton module UI
    public Enemy enemy;    // ta logique métier

    public RectTransform damageTextParent; // un container dans ton Canvas
    private GameObject damageTextPrefab;

    public Transform damagePoint;

    // Dossier où sont stockées les icônes de type
    private const string typeSpritePath = "Sprites/types_fr_"; // base du nom

    void Awake()
    {
        damageTextPrefab = Resources.Load<GameObject>("Prefabs/DamageText");
    }

    public void Bind(Enemy e)
    {
        enemy = e;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (enemy == null || enemy.pokemon == null) return;

        var p = enemy.pokemon;

        // --- Nom + Niveau ---
        ui.nameAndLevelText.text = $"{p.nom}  Niv {p.niveau}";

        // --- Sprite principal ---
        ui.spriteImage.sprite = p.sprite;

        // --- Types ---
        // Type 1
        ui.typeImage1.sprite = ui.typeSprites[p.type1];
        ui.typeImage1.gameObject.SetActive(p.type1 != Pokemon.listTypeName.aucun);

        // Type 2
        ui.typeImage2.sprite = ui.typeSprites[p.type2];
        ui.typeImage2.gameObject.SetActive(p.type2 != Pokemon.listTypeName.aucun);

        // --- PV ---
        ui.hpSlider.maxValue = p.maxPv;
        ui.hpSlider.value = p.currentPv;
    }

    public void SpawnDamageText(int damage, Vector3 worldPosition)
    {
        //Vector2 screenPos = Camera.main.WorldToScreenPoint(worldPosition);
        Vector2 screenPos = worldPosition;

        GameObject go = Instantiate(damageTextPrefab, damageTextParent);
        go.transform.position = screenPos;

        go.GetComponent<DamageText>().Init(damage);
    }
}
