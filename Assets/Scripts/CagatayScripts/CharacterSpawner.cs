using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject characterPrefab;
    public Transform spawnPoint;
    public Button randomizeButton;
    public TextMeshProUGUI statsText;

    private GameObject currentCharacter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomizeButton.onClick.AddListener(SpawnRandomCharacter);
    }

    private void SpawnRandomCharacter()
    {
        if(currentCharacter != null)
        {
            Destroy(currentCharacter);
        }

        CharacterStats newStats = ScriptableObject.CreateInstance<CharacterStats>();
        newStats.GenerateRandomStats();

        currentCharacter = Instantiate(characterPrefab, spawnPoint.position, Quaternion.identity);
        Character characterComponent = currentCharacter.GetComponent<Character>();

        characterComponent.statsText = statsText;
        characterComponent.Initialize(newStats);

    }
}
