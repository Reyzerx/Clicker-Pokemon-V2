using TMPro;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float moveSpeed = 100f;
    public float fadeSpeed = 1f;

    private CanvasGroup canvasGroup;
    private Vector3 direction;
    private float timeAlive;

    void Awake()
    {
        // Sécurise la récupération du CanvasGroup
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }

        // Direction aléatoire plus dynamique
        float randomX = Random.Range(-1.5f, 1.5f);
        float randomY = Random.Range(-4.0f, 4.0f);
        direction = new Vector3(randomX, randomY, 0f);

        // Apparition en "pop"
        transform.localScale = Vector3.zero;
    }

    public void Init(int damage)
    {
        if (text == null)
        {
            Debug.LogError("⚠ Le champ 'text' n'est pas assigné dans le prefab DamageText !");
            return;
        }

        text.text = "-" + damage.ToString();
        text.color = Color.red;
        canvasGroup.alpha = 1f; // assure que le texte est visible
    }

    void Update()
    {
        timeAlive += Time.deltaTime;

        // Animation de montée
        transform.position += direction * moveSpeed * Time.deltaTime;

        // Fade out progressif
        canvasGroup.alpha -= fadeSpeed * Time.deltaTime;

        // Animation de scale (pop)
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, Time.deltaTime * 6f);

        // Suppression automatique
        if (canvasGroup.alpha <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
