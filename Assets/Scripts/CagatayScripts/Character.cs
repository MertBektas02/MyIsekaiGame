using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public CharacterStats stats;
    public Renderer characterRenderer;
    public TextMeshProUGUI statsText;

    [SerializeField]
    private float speed = 1f;
    public void Initialize(CharacterStats newStats)
    {
        stats = newStats;

        Color randomColor = new Color(Random.value, Random.value, Random.value);
        characterRenderer.material.color = randomColor;

        float randomSizeX = Random.Range(0.8f, 1.2f);
        float randomSizeY = Random.Range(0.7f, 1.5f);
        float randomSizeZ = Random.Range(0.9f, 1.1f);
        transform.localScale = new Vector3(randomSizeX, randomSizeY, randomSizeZ);

        if(statsText != null)
        {
            statsText.text = $"Spawned: {stats.characterName}\nSTR: {stats.strength}\nSTM: {stats.stamina}\nINT: {stats.intelligence}\nCHR: {stats.charisma}\nWLP: {stats.willPower}\nDXT: {stats.dexterity}";
        }
        Debug.Log($"Spawned: {stats.characterName} | STR: {stats.strength}, STM: {stats.stamina}, INT: {stats.intelligence}, CHR: {stats.charisma}, WLP: {stats.willPower}, DXT: {stats.dexterity}");
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
